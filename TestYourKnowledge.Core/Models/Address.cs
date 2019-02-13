using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYourKnowledge.Core.Models
{
    public class Address:IEntityAudit
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Addressline1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string County { get; set; }

        [Required]
        public string PostCode { get; set; }
        public long CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
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
