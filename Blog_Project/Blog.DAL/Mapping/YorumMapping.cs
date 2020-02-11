using Blog.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Mapping
{
    public class YorumMapping : EntityTypeConfiguration<Yorum>
    {
        public YorumMapping()
        {
            ToTable("Yorumlar");
            Property(y => y.YorumId).IsRequired();
            Property(y => y.AdSoyad).HasColumnType("varchar").HasMaxLength(40).IsOptional();
            Property(y => y.YorumTarihi).HasColumnType("date").IsRequired();
            Property(y => y.YorumYazisi).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}
