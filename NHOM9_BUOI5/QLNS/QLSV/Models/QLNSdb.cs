using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLSV.Models
{
    public partial class QLNSdb : DbContext
    {
        public QLNSdb()
            : base("name=QLNSdb")
        {
        }

        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MAPB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONGBAN>()
                .Property(e => e.MAPB)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
