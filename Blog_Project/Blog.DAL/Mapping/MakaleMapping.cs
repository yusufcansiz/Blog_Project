using Blog.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Mapping
{
    public class MakaleMapping : EntityTypeConfiguration<Makale>
    {
        public MakaleMapping()
        {
            ToTable("Makaleler");
            Property(m => m.MakaleId).IsRequired();
            Property(m => m.KullaniciId).IsRequired();
            Property(m => m.Baslik).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            Property(m => m.BegenmeSayisi).IsOptional();
            Property(m => m.GoruntulemeSayisi).IsOptional();
            Property(m => m.Ozet).HasMaxLength(150).IsRequired().HasColumnType("varchar");
            Property(m => m.Yazi).IsRequired().HasColumnType("varchar").HasMaxLength(4000);
            Property(m => m.YazimTarihi).IsRequired().HasColumnType("date");
        }
    }
}
