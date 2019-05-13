using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class City
    {
        [DataMember]
        public string CityName { get; set; }

        [DataMember]
        public int PostalCode { get; set; }
    }
}
