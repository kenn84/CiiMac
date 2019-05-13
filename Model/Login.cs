using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Login
    {
        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public int Phone { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public Enum Level { get; set; }
    }
}
