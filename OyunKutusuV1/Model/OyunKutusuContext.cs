using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OyunKutusuV1.Model
{
    public partial class OyunKutusuContext : DbContext
    {
        public OyunKutusuContext()
            : base("name=OyunKutusuContext")
        {
        }

        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Oyun> Oyun { get; set; }
        public virtual DbSet<Skor> Skor { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oyun>()
                .Property(e => e.ad)
                .IsFixedLength();
        }
    }
}
