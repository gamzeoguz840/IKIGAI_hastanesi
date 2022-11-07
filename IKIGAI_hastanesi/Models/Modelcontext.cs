using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace IKIGAI_hastanesi.Models
{
    public partial class Modelcontext : DbContext
    {
        public Modelcontext()
            : base("name=Modelcontext")
        {
        }

        public virtual DbSet<doktorlogin> doktorlogin { get; set; }
        public virtual DbSet<hasta> hasta { get; set; }
        public virtual DbSet<hastasonuc> hastasonuc { get; set; }
        public virtual DbSet<hepsi> hepsi { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<doktorlogin>()
                .Property(e => e.doktortc)
                .IsFixedLength();

            modelBuilder.Entity<doktorlogin>()
                .Property(e => e.doktorsifre)
                .IsFixedLength();

            modelBuilder.Entity<doktorlogin>()
                .Property(e => e.doktorad)
                .IsFixedLength();

            modelBuilder.Entity<doktorlogin>()
                .Property(e => e.doktorsoyad)
                .IsFixedLength();

            modelBuilder.Entity<doktorlogin>()
                .Property(e => e.doktorbolum)
                .IsFixedLength();

            modelBuilder.Entity<doktorlogin>()
                .Property(e => e.doktoryas)
                .IsFixedLength();

            modelBuilder.Entity<hasta>()
                .Property(e => e.hastaad)
                .IsFixedLength();

            modelBuilder.Entity<hasta>()
                .Property(e => e.hastasoyad)
                .IsFixedLength();

            modelBuilder.Entity<hasta>()
                .Property(e => e.hastatc)
                .IsFixedLength();

            modelBuilder.Entity<hasta>()
                .Property(e => e.hastadogum)
                .IsFixedLength();

            modelBuilder.Entity<hasta>()
                .Property(e => e.hastabolum)
                .IsFixedLength();

            modelBuilder.Entity<hasta>()
                .Property(e => e.hastadoktor)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.hastaad)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.hastasoyad)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.hastatc)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.hastadogum)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.hastabolum)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.hastadoktor)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.hastateshis)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.hastailac)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.lab)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.ameliyat)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.ucreta)
                .IsFixedLength();

            modelBuilder.Entity<hastasonuc>()
                .Property(e => e.ucretlab)
                .IsFixedLength();
        }
    }
}
