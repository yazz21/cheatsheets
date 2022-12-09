using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using XOKA_API_Mineral.Models;

namespace XOKA_API_Mineral.Data
{
    public partial class XOKA_OROMADAContext : DbContext
    {
        // public XOKA_OROMADAContext()
        // {
        // }

        public XOKA_OROMADAContext(DbContextOptions<XOKA_OROMADAContext> options)
            : base(options)
        {
        }

        public DbSet<Mineral> Minerals { get; set; } 
        public DbSet<MineralUse> Mineral_Uses { get; set; } 
        public DbSet<ResourceDeposit> Resource_Deposits { get; set; } 
        public virtual DbSet<Site> Sites { get; set; } = null!;
        public DbSet<Woredas> woredas { get; set; } 
        public DbSet<Regions> regions { get; set; } 
        public DbSet<Zones> zones { get; set; } 
        public virtual DbSet<PlotRegistration> PlotRegistration { get; set; }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                 optionsBuilder.UseSqlServer("server=192.168.0.104\\XOKASQL2017;Database=XOKA_OROMADA;User id=dev;Password=dev");
//             }
//         }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Site>(entity =>
        //     {
        //         entity.ToTable("Site");

        //         entity.Property(e => e.SiteId)
        //             .ValueGeneratedNever()
        //             .HasColumnName("Site_ID");

        //         entity.Property(e => e.ApplicationNo)
        //             .HasMaxLength(50)
        //             .HasColumnName("Application_No");

        //         entity.Property(e => e.Coordinate).HasMaxLength(500);

        //         entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

        //         entity.Property(e => e.CreatedDate)
        //             .HasColumnType("datetime")
        //             .HasColumnName("Created_Date");

        //         entity.Property(e => e.DateRegistered)
        //             .HasColumnType("date")
        //             .HasColumnName("Date_Registered");

        //         entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

        //         entity.Property(e => e.DeletedDate)
        //             .HasColumnType("datetime")
        //             .HasColumnName("Deleted_Date");

        //         entity.Property(e => e.IsActive).HasColumnName("Is_Active");

        //         entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

        //         entity.Property(e => e.KebeleLocality)
        //             .HasMaxLength(500)
        //             .HasColumnName("Kebele_Locality");

        //         entity.Property(e => e.LicenceServiceId).HasColumnName("Licence_Service_ID");

        //         entity.Property(e => e.Remarks).HasMaxLength(500);

        //         entity.Property(e => e.SiteName)
        //             .HasMaxLength(50)
        //             .HasColumnName("Site_Name");

        //         entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

        //         entity.Property(e => e.UpdatedDate)
        //             .HasColumnType("datetime")
        //             .HasColumnName("Updated_Date");
        //     });

        //     OnModelCreatingPartial(modelBuilder);
        // }

        // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
