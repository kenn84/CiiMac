using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBModels
{
    [Table("Company")]
    public class CompanyDbModel
    {
        [Key]
        public Guid CompanyId { get; set; }


        public Guid LoginId { get; set; }
        [ForeignKey("LoginId")]
        public LoginDbModel login { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string CVR { get; set; }

        [Required]
        public string ContactPerson { get; set; }

    }
}
