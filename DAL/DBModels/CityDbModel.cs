using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBModels
{
    [Table("City")]
    public class CityDbModel
    {

        [Key]
        public Guid Id { get; set; }


        public string CityName { get; set; }

        public int PostalCode { get; set; }
    }
}
