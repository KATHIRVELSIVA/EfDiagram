using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfDiagram.Models
{
    public class InsuranceApplyModel
    {
        [Key]
        public int ApplyId { get; set; }
        [ForeignKey("UserID")]
        public required UserModel UserModel { get; set; }
        [ForeignKey("PolicyID")]
        public required PolicyModel PolicyModelID { get; set; }
        [ForeignKey("AddOnPolicyID")]
        public required AddOnPolicyModel AddOnPolicy { get; set; }
        public string ? status { get; set; }
    }
}
