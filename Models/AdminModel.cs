using System.ComponentModel.DataAnnotations;

namespace EfDiagram.Models
{
    public class AdminModel
    {
        [Key]
        public int AdminID { get; set; }
        public string? EmailID { get; set; }
        public string? Password { get; set; }
    }
}
