using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfDiagram.Models
{
    public class ClaimAmountModel
    {
        [Key]
        public int Id {  get; set; }
        [ForeignKey("PolicyID")]
        public required PolicyModel PolicyId { get; set; }
        [ForeignKey("AddOnPolicyID")]
        public required AddOnPolicyModel AddOnPolicyId { get; set; }
        [ForeignKey("ClaimID")]
        public required ClaimModel ClaimId { get; set; }
        [ForeignKey("IDVvalue")]
        public required VehicleModel VehicleID { get; set; }
        public double ClaimAmount { get; set; }
    }
}
