using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDB
    {
        public int CreateLogin(Login login, Dictionary<string, byte[]> passwordHashAndSalt)
        {
            int loginId = 0;

            string cmdText = SqlQueries.GetLoginStrings()["Create"];

            using (SqlConnection con = DBConnection.OpenCon())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SqlQueries.GetLoginStrings()["Create"];

                    SqlParameter phone = new SqlParameter("@phone", System.Data.SqlDbType.Text, 8);
                    phone.Value = login.Phone;

                    SqlParameter email = new SqlParameter("@email", System.Data.SqlDbType.Text, 55);
                    email.Value = login.Email;

                    SqlParameter level = new SqlParameter("@level", System.Data.SqlDbType.Int);
                    level.Value = login.Level;

                    SqlParameter password = new SqlParameter("@password", System.Data.SqlDbType.Binary);
                    password.Value = passwordHashAndSalt["completePassword"];

                    SqlParameter salt = new SqlParameter("@salt", System.Data.SqlDbType.Binary);
                    salt.Value = passwordHashAndSalt["passwordSalt"];

                    cmd.Parameters.Add(phone);
                    cmd.Parameters.Add(email);
                    cmd.Parameters.Add(level);
                    cmd.Parameters.Add(password);
                    cmd.Parameters.Add(salt);

                    try
                    {
                        loginId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {
                        throw new FaultException(ex.ToString());
                    }
                }
            }
            return loginId;
        }

    }
}

