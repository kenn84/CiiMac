using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Company
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CVR { get; set; }

        [DataMember]
        public string ContactPerson { get; set; }

        [DataMember]
        public List<Address> CompanyAddresses { get; set; }
    }
}
