using Blog.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Mapping
{
    public class KullaniciMapping : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMapping()
        {
            ToTable("Kullanıcılar");
            Property(k => k.KullaniciId).IsRequired();
            Property(k => k.Email).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            Property(k => k.Sifre).HasColumnType("varchar").HasMaxLength(15).IsRequired();
            Property(k => k.Ad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            Property(k => k.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
        }
    }
}
