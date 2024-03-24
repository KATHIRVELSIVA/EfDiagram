using System.ComponentModel.DataAnnotations.Schema;

namespace EfDiagram.Models
{
    public class PdfDocumentModel
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] FIelData { get; set; }
        public DateTime UploadDate { get; set; }
        [ForeignKey("UserID")]
        public UserModel User { get; set; }
    }
}
