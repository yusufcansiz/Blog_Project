using Blog.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Mapping
{
    public class KategoriMapping : EntityTypeConfiguration<Kategori>
    {
        public KategoriMapping()
        {
            ToTable("Kategoriler");
            Property(k => k.KategoriId).IsRequired();
            Property(k => k.KategoriAdi).IsRequired().HasMaxLength(30).HasColumnType("varchar");
            Property(k => k.UstKategoriId).IsRequired();
        }
    }
}
