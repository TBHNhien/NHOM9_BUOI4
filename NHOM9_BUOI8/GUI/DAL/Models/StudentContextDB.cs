using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Models
{
    public partial class StudentContextDB : DbContext
    {
        public StudentContextDB()
            : base("name=StudentContextDB")
        {
        }

        public virtual DbSet<FACULTY> FACULTies { get; set; }
        public virtual DbSet<MAJOR> MAJORs { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FACULTY>()
                .HasMany(e => e.STUDENTs)
                .WithOptional(e => e.FACULTY)
                .HasForeignKey(e => e.FacultyId);

            modelBuilder.Entity<FACULTY>()
                .HasMany(e => e.MAJORs)
                .WithRequired(e => e.FACULTY)
                .HasForeignKey(e => e.FALCULTYID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACULTY>()
                .HasMany(e => e.STUDENTs1)
                .WithOptional(e => e.FACULTY1)
                .HasForeignKey(e => e.FacultyId);

            modelBuilder.Entity<MAJOR>()
                .HasMany(e => e.STUDENTs)
                .WithOptional(e => e.MAJOR)
                .HasForeignKey(e => new { e.FacultyId, e.MAJORID });
        }
    }
}
