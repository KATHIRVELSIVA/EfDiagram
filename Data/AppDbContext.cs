using EfDiagram.Models;
using Microsoft.EntityFrameworkCore;


namespace EfDiagram.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<AddOnPolicyModel> AddOnPolicy { get; set; }
        public DbSet<PolicyModel> Policy { get; set; }
        public DbSet<ClaimModel> Claim { get; set; }
        public DbSet<AdminModel> Admin { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<InsuranceApplyModel> InsuranceApply { get; set; }
        public DbSet<ClaimAmountModel> ClaimAmounts { get; set; }
        public DbSet<VehicleModel> VehicleModel { get; set; }
        public DbSet<PdfDocumentModel> PdfDocument { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserModel>()
                .HasIndex(u => u.EmailID)
                .IsUnique();
            builder.Entity<VehicleModel>()
                .HasIndex(u => u.VehicleId)
                .IsUnique();
        }

    }
}
