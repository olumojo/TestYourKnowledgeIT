using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Core.Models
{
    public class Test: IEntityAudit
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

        [ForeignKey("UserId")]
        public virtual User User { get; set; }


        public long UserId { get; set; }

        [Required]
        public DateTime DateOfTest { get; set; }

        public decimal? TotalScore { get; set; }
    }
}
