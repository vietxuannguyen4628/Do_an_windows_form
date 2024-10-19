using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Do_An_WindowsForm.model
{
    public partial class QuanLyNhaTroDB : DbContext
    {
        public QuanLyNhaTroDB()
            : base("name=QuanLyNhaTroDB")
        {
        }

        public virtual DbSet<CT_SuDungDV> CT_SuDungDV { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<PhieuDenBu> PhieuDenBus { get; set; }
        public virtual DbSet<PhieuSuDungDV> PhieuSuDungDVs { get; set; }
        public virtual DbSet<PhieuThuePhong> PhieuThuePhongs { get; set; }
        public virtual DbSet<PhieuTraPhong> PhieuTraPhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.CT_SuDungDV)
                .WithRequired(e => e.DichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND_CanCuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuThuePhongs)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuSuDungDV>()
                .HasMany(e => e.CT_SuDungDV)
                .WithRequired(e => e.PhieuSuDungDV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuThuePhong>()
                .HasMany(e => e.PhieuDenBus)
                .WithRequired(e => e.PhieuThuePhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuThuePhong>()
                .HasMany(e => e.PhieuSuDungDVs)
                .WithRequired(e => e.PhieuThuePhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuThuePhong>()
                .HasMany(e => e.PhieuTraPhongs)
                .WithRequired(e => e.PhieuThuePhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.PhieuThuePhongs)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);
        }
    }
}
