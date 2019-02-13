using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Core.Models
{
    public class Score:IEntityAudit
    {

        [Key]
        public long Id { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        [Required]
        public bool Enabled { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        public decimal Points { get; set; }
    }
}
