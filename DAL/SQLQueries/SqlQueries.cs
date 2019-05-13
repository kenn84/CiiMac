using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlQueries
    {
        public static Dictionary<string, string> GetLoginStrings()
        {
            Dictionary<string, string> strings = new Dictionary<string, string>()
            {
                { "Create", "INSERT INTO Login (phone, email, level, password, salt) VALUES(@phone, @email, @level, @passwordHash, @passwordSalt)"},
            };
            return strings;
        }
    }
}
