using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public bool CompanyAddressOrDeliveryAddress { get; set; }

        [DataMember]
        public string StreetName { get; set; }

        [DataMember]
        public int HouseNo { get; set; }

        [DataMember]
        public int Floor { get; set; }

        [DataMember]
        public string Direction { get; set; }
    }
}
