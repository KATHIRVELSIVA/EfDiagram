using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfDiagram.Models
{
    public class ClaimModel
    {
        [Key]
        public int ClaimID { get; set; }
        public string? ClaimName { get; set; }
        public string? ClaimReason { get; set; }
        public string? FIRNo { get; set; }
        public string ? Status { get; set; }
        [ForeignKey("ApplyId")]
        public InsuranceApplyModel InsuranceApplyId { get; set; }

    }
}
