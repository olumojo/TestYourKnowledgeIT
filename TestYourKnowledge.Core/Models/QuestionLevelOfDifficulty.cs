using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Core.Models
{
    public class QuestionLevelOfDifficulty:IEntityAudit
    {
        [Key]
        public long Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Description { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        [Required]
        public bool Enabled { get; set; }

        [StringLength(15)]
        [Required]
        public string Title { get; set; }

        public long ScoreId { get; set; }

        [ForeignKey("ScoreId")]
        public virtual Score Score { get; set; }
    }
}
