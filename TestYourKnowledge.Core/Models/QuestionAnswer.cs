using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Core.Models
{
    public class QuestionAnswer:IEntityAudit
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public bool Enabled { get; set; }

        public long QuestionAnswerCatrgoryId { get; set; }

        [ForeignKey("QuestionAnswerCatrgoryId")]
        public virtual QuestionAnswerCatrgory QuestionAnswerCatrgory { get; set; }

        public bool CorrectAnswer { get; set; }


    }
}
