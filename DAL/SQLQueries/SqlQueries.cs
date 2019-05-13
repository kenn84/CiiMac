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

        public static Dictionary<string, string> GetCompanyStrings()
        {
            Dictionary<string, string> strings = new Dictionary<string, string>()
            {
                { "Create", "INSERT INTO Company (name, cvr, contactPerson) VALUES(@name, @cvr, @contactPerson)"},
            };
            return strings;
        }

        public static Dictionary<string, string> GetCityStrings()
        {
            Dictionary<string, string> strings = new Dictionary<string, string>()
            {
                { "Create", "INSERT INTO City (cityName, postalCode) VALUES(@cityName, @postalCode)"},
            };
            return strings;
        }

        public static Dictionary<string, string> GetCountryStrings()
        {
            Dictionary<string, string> strings = new Dictionary<string, string>()
            {
                { "Create", "INSERT INTO Country (countryName, countryCode) VALUES(@countryName, @countryCode)"},
            };
            return strings;
        }

        public static Dictionary<string, string> GetAddressStrings()
        {
            Dictionary<string, string> strings = new Dictionary<string, string>()
            {
                { "Create", "INSERT INTO Address (streetName, houseNo, floor, direction, companyAddressOrDeliveryAddress) VALUES(@streetName, @houseNo, @floor, @direction, @companyAddressOrDeliveryAddress)"},
            };
            return strings;
        }
    }
}
