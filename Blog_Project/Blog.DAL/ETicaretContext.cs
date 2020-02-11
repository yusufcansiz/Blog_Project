using Blog.DAL.Mapping;
using Blog.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL
{
    public class ETicaretContext : DbContext
    {
        public ETicaretContext() : base(ConnectionStringContainer.ConnectionString)
        {

        }

        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Makale> Makaleler { get; set; }

        public DbSet<Yorum> Yorumlar { get; set; }

        public DbSet<Etiket> Etiketler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KategoriMapping());
            modelBuilder.Configurations.Add(new KullaniciMapping());
            modelBuilder.Configurations.Add(new MakaleMapping());
            modelBuilder.Configurations.Add(new YorumMapping());
            modelBuilder.Configurations.Add(new EtiketMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
