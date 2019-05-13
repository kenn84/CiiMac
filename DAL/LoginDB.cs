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

        public void CreateCompany(Login login, Company company, Dictionary<string, byte[]> passwordHashAndSalt)
        {
            int companyId = 0;
            using (SqlConnection con = DBConnection.OpenCon())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SqlQueries.GetCompanyStrings()["Create"];

                    SqlParameter name = new SqlParameter("@name", System.Data.SqlDbType.Text, 55);
                    name.Value = company.Name;

                    SqlParameter cvr = new SqlParameter("@cvr", System.Data.SqlDbType.Text, 55);
                    cvr.Value = company.CVR;

                    SqlParameter contactPerson = new SqlParameter("@contactPerson", System.Data.SqlDbType.Int);
                    contactPerson.Value = company.ContactPerson;


                    cmd.Parameters.Add(name);
                    cmd.Parameters.Add(cvr);
                    cmd.Parameters.Add(contactPerson);

                    try
                    {
                        companyId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {
                        throw new FaultException(ex.ToString());
                    }
                }
            }
        }

        public int CreateCountry(Country country)
        {
            int countryId = 0;
            using (SqlConnection con = DBConnection.OpenCon())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SqlQueries.GetCountryStrings()["Create"];

                    SqlParameter countryName = new SqlParameter("@countryName", System.Data.SqlDbType.Text, 55);
                    countryName.Value = country.CountryName;

                    SqlParameter countryCode = new SqlParameter("@countryCode", System.Data.SqlDbType.Text, 55);
                    countryCode.Value = country.CountryCode;

                    cmd.Parameters.Add(countryName);
                    cmd.Parameters.Add(countryCode);

                    try
                    {
                        countryId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {
                        throw new FaultException(ex.ToString());
                    }
                }
            }
            return countryId;
        }

        public int CreateCity(City city)
        {
            int cityId = 0;
            using (SqlConnection con = DBConnection.OpenCon())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SqlQueries.GetCityStrings()["Create"];

                    SqlParameter cityName = new SqlParameter("@cityName", System.Data.SqlDbType.Text, 55);
                    cityName.Value = city.CityName;

                    SqlParameter postalCode = new SqlParameter("@postalCode", System.Data.SqlDbType.Text, 55);
                    postalCode.Value = city.PostalCode;

                    cmd.Parameters.Add(cityName);
                    cmd.Parameters.Add(postalCode);

                    try
                    {
                        cityId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {
                        throw new FaultException(ex.ToString());
                    }
                }
            }
            return cityId;
        }

        public int CreateAddress(Address address)
        {
            int addressId = 0;
            using (SqlConnection con = DBConnection.OpenCon())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SqlQueries.GetCityStrings()["Create"];

                    SqlParameter streetName = new SqlParameter("@streetName", System.Data.SqlDbType.Text, 55);
                    streetName.Value = address.StreetName;

                    SqlParameter houseNo = new SqlParameter("@houseNo", System.Data.SqlDbType.Int);
                    houseNo.Value = address.HouseNo;

                    SqlParameter floor = new SqlParameter("@floor", System.Data.SqlDbType.Int);
                    floor.Value = address.Floor;

                    SqlParameter direction = new SqlParameter("@direction", System.Data.SqlDbType.Text, 55);
                    direction.Value = address.Direction;

                    SqlParameter companyAddressOrDeliveryAddress = new SqlParameter("@companyAddressOrDeliveryAddress", System.Data.SqlDbType.Text, 55);
                    companyAddressOrDeliveryAddress.Value = address.CompanyAddressOrDeliveryAddress;

                    cmd.Parameters.Add(streetName);
                    cmd.Parameters.Add(houseNo);
                    cmd.Parameters.Add(floor);
                    cmd.Parameters.Add(direction);
                    cmd.Parameters.Add(companyAddressOrDeliveryAddress);

                    try
                    {
                        addressId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {
                        throw new FaultException(ex.ToString());
                    }
                }
            }
            return addressId;
        }
    }
}

