using System.ComponentModel.DataAnnotations;

namespace EfDiagram.Models
{
    public class AddOnPolicyModel
    {
        [Key]
        public int AddOnPolicyID { get; set; }
        public string ? AddOnPolicyName { get; set; }
        public string ? AddOnPolicyDescription { get; set; }
        public float ? AddOnPrice { get; set; }
        public bool ? AddOnStatus { get; set; }  
    }
}
