using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Core.Models
{
    public class User:IEntityAudit
    {
        [Key]
        public long Id { get; set; }


        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }


        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public string Password { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
        public long AddressId { get; set; }

        [Required(ErrorMessage = "Email Address can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        public string PersonalPref { get; set; }
        public bool IsActive { get; set; }
        public string PasswordHash { get; set; }
        public string Passwordsalt { get; set; }

        [ForeignKey("RecoveryQuestionsId")]
        public virtual RecoveryQuestion SecretQuestion { get; set; }


        public long RecoveryQuestionsId { get; set; }
        public string SecretAnswer { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        [Required]
        public bool Enabled { get; set; }

        public string Token { get; set; }
    }
}
