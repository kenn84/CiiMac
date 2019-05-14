using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBModels
{
    [Table("Country")]
    public class CountryDbModel
    {
        [Key]
        public Guid Id { get; set; }



        public string CountryName { get; set; }
        public int CountryCode { get; set; }
    }
}
