using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Core.Models
{
    public class Question:IEntityAudit
    {
        [Key]
        public long Id { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(50)]
        public string ToolTip { get; set; }

        [Required]
        public int TimeAllowedOnQuestion { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        [Required]
        public bool Enabled { get; set; }
        public int? DisplayOrder { get; set; }

        public long QuestionLevelOfDifficultyId { get; set; }

        [ForeignKey("QuestionLevelOfDifficultyId")]
        public virtual QuestionLevelOfDifficulty QuestionLevelOfDifficulty { get; set; }
    }
}
