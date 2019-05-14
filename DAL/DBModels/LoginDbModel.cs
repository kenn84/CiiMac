using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBModels
{
    [Table("Login")]
    public class LoginDbModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        private byte[] CompletePassword { get; set; }

        [Required]
        private byte[] PasswordSalt { get; set; }

    }
}
