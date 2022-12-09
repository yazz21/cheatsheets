using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace XOKA_API_Mineral.Models
{
    public partial class XOKA_OROMADAContext : DbContext
    {
        public XOKA_OROMADAContext()
        {
        }

        public XOKA_OROMADAContext(DbContextOptions<XOKA_OROMADAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=192.168.0.104\\XOKASQL2017;Database=XOKA_OROMADA;User id=dev;Password=dev");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.ApplicantFirstNameAm)
                    .HasColumnName("Applicant_First_Name_AM")
                    .HasMaxLength(500);

                entity.Property(e => e.ApplicantFirstNameEn)
                    .HasColumnName("Applicant_First_Name_EN")
                    .HasMaxLength(500);

                entity.Property(e => e.ApplicantLastNameAm)
                    .HasColumnName("Applicant_Last_Name_AM")
                    .HasMaxLength(500);

                entity.Property(e => e.ApplicantLastNameEn)
                    .HasColumnName("Applicant_Last_Name_EN")
                    .HasMaxLength(500);

                entity.Property(e => e.ApplicantMiddleNameAm)
                    .HasColumnName("Applicant_Middle_Name_AM")
                    .HasMaxLength(500);

                entity.Property(e => e.ApplicantMiddleNameEn)
                    .HasColumnName("Applicant_Middle_Name_En")
                    .HasMaxLength(500);

                entity.Property(e => e.ApplicantMotherNameAm)
                    .HasColumnName("Applicant_Mother_Name_AM")
                    .HasMaxLength(500);

                entity.Property(e => e.ApplicantMotherNameEn)
                    .HasColumnName("Applicant_Mother_Name_EN")
                    .HasMaxLength(500);

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerStatus).HasColumnName("Customer_Status");

                entity.Property(e => e.CustomerTypeId).HasColumnName("Customer_Type_ID");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.DeletedDate)
                    .HasColumnName("Deleted_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(500);

                entity.Property(e => e.HomeTelephone)
                    .HasColumnName("Home_Telephone")
                    .HasMaxLength(20);

                entity.Property(e => e.HouseNo)
                    .HasColumnName("House_No")
                    .HasMaxLength(20);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.IsRepresentative).HasColumnName("Is_Representative");

                entity.Property(e => e.IsRepresented).HasColumnName("Is_Represented");

                entity.Property(e => e.IsThem).HasColumnName("Is_them");

                entity.Property(e => e.Kebele).HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasColumnName("Mobile_No")
                    .HasMaxLength(20);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.ParentCustomerId).HasColumnName("Parent_Customer_ID");

                entity.Property(e => e.PassportId)
                    .HasColumnName("Passport_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ResidenceCountry)
                    .HasColumnName("Residence_Country")
                    .HasMaxLength(50);

                entity.Property(e => e.SdpId).HasColumnName("SDP_ID");

                entity.Property(e => e.StateRegion)
                    .HasColumnName("State_Region")
                    .HasMaxLength(100);

                entity.Property(e => e.Tin)
                    .IsRequired()
                    .HasColumnName("TIN")
                    .HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.WeredaId).HasColumnName("Wereda_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
