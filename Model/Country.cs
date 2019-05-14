using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Country
    {
        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public int CountryCode { get; set; }
    }
}
