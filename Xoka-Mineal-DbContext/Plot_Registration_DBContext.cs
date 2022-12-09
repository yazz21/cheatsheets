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

        public virtual DbSet<PlotRegistration> PlotRegistration { get; set; }

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
            modelBuilder.Entity<PlotRegistration>(entity =>
            {
                entity.HasKey(e => e.PlotId)
                    .HasName("PK_Parcel_Registration");

                entity.ToTable("Plot_Registration");

                entity.Property(e => e.PlotId)
                    .HasColumnName("Plot_ID")
                    .HasMaxLength(400);

                entity.Property(e => e.ApplicationNo)
                    .IsRequired()
                    .HasColumnName("Application_No")
                    .HasMaxLength(50);

                entity.Property(e => e.BlockNo).HasColumnName("Block_No");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.DeletedDate)
                    .HasColumnName("Deleted_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.EPlotId)
                    .HasColumnName("E_Plot_ID")
                    .HasMaxLength(400);

                entity.Property(e => e.GisXCoordinate1).HasColumnName("GIS_X_Coordinate_1");

                entity.Property(e => e.GisXCoordinate2).HasColumnName("GIS_X_Coordinate_2");

                entity.Property(e => e.GisXCoordinate3).HasColumnName("GIS_X_Coordinate_3");

                entity.Property(e => e.GisXCoordinate4).HasColumnName("GIS_X_Coordinate_4");

                entity.Property(e => e.GisXCoordinate5).HasColumnName("GIS_X_Coordinate_5");

                entity.Property(e => e.GisXCoordinate6).HasColumnName("GIS_X_Coordinate_6");

                entity.Property(e => e.GisXCoordinate7).HasColumnName("GIS_X_Coordinate_7");

                entity.Property(e => e.GisXCoordinate8).HasColumnName("GIS_X_Coordinate_8");

                entity.Property(e => e.GisYCoordinate1).HasColumnName("GIS_Y_Coordinate_1");

                entity.Property(e => e.GisYCoordinate2).HasColumnName("GIS_Y_Coordinate_2");

                entity.Property(e => e.GisYCoordinate3).HasColumnName("GIS_Y_Coordinate_3");

                entity.Property(e => e.GisYCoordinate4).HasColumnName("GIS_Y_Coordinate_4");

                entity.Property(e => e.GisYCoordinate5).HasColumnName("GIS_Y_Coordinate_5");

                entity.Property(e => e.GisYCoordinate6).HasColumnName("GIS_Y_Coordinate_6");

                entity.Property(e => e.GisYCoordinate7).HasColumnName("GIS_Y_Coordinate_7");

                entity.Property(e => e.GisYCoordinate8).HasColumnName("GIS_Y_Coordinate_8");

                entity.Property(e => e.HouseNo)
                    .HasColumnName("House_No")
                    .HasMaxLength(10);

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.LandGradeId).HasColumnName("Land_Grade_ID");

                entity.Property(e => e.LicenceServiceId).HasColumnName("Licence_Service_ID");

                entity.Property(e => e.NPlotId)
                    .HasColumnName("N_Plot_ID")
                    .HasMaxLength(400);

                entity.Property(e => e.NortechNo)
                    .HasColumnName("Nortech_No")
                    .HasMaxLength(400);

                entity.Property(e => e.ParcelNo)
                    .IsRequired()
                    .HasColumnName("Parcel_No")
                    .HasMaxLength(50);

                entity.Property(e => e.PlotSizeM2).HasColumnName("Plot_Size_M2");

                entity.Property(e => e.PlotStatus).HasColumnName("Plot_Status");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SPlotId)
                    .HasColumnName("S_Plot_ID")
                    .HasMaxLength(400);

                entity.Property(e => e.SdpId).HasColumnName("SDP_ID");

                entity.Property(e => e.StreetNo)
                    .HasColumnName("Street_No")
                    .HasMaxLength(400);

                entity.Property(e => e.TypeOfUseId).HasColumnName("Type_Of_Use_ID");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.WPlotId)
                    .HasColumnName("W_Plot_ID")
                    .HasMaxLength(400);

                entity.Property(e => e.WeredaId).HasColumnName("Wereda_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
