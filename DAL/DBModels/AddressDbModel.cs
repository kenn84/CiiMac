using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBModels
{
    [Table("Address")]
    public class AddressDbModel
    {

        [Key]
        public Guid Id { get; set; }


        public string StreetName { get; set; }
        public int HouseNo { get; set; }
        public int Floor { get; set; }
        public string Direction { get; set; }
        public bool CompanyAddressOrDeliveryAddress { get; set; }
    }
}
