using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Core.Models
{
    public class TestQuestionAnswerMap :IEntityAudit
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

        [ForeignKey("TestId")]
        public virtual Test Test { get; set; }


        public long TestId { get; set; }

        public long QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        public long QuestionAnswerId { get; set; }

        [ForeignKey("QuestionAnswerId")]
        public virtual QuestionAnswer QuestionAnswer { get; set; }

        public string AnswerTest { get; set; }

        [Required]
        public long TimeSpentOnQuestion { get; set; }

        public long? AnsweredOrder { get; set; }

        public decimal Score { get; set; }

    }
}
