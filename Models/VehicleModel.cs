﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfDiagram.Models
{
    public class VehicleModel
    {
        [Key]
        public int VehicleId { get; set; }
        public string? VehicleNo { get; set; }
        public string? VehicleName { get; set; }
        public string? VehicleType { get; set; }
        public string? Location { get; set; }
        public string? YearOfMake { get; set; }
        public int? IDVvalue { get; set; }
        public bool Status { get; set; }
        [ForeignKey("UserID")]
        public UserModel? UserModel { get; set; }
    }
}
