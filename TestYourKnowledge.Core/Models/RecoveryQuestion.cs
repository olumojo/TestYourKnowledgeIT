using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Core.Models
{
    public class RecoveryQuestion:IEntityAudit
    {
        [Key]
        public long Id { set; get; }

        [Required]
        [StringLength(500)]
        public string RecoveryQuestionDescription { set; get; }

        [Required]
        public bool Enabled { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
