using Blog.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Mapping
{
    public class EtiketMapping : EntityTypeConfiguration<Etiket>
    {
        public EtiketMapping()
        {
            ToTable("Etiket");
            Property(e => e.EtiketId).IsRequired();
            Property(e => e.EtiketAdi).IsRequired().HasMaxLength(15).HasColumnType("varchar").IsRequired();
            Property(e => e.Detay).HasColumnType("varchar");
        }
    }
}

//HasMany(x=>x.Tags).WithMany(x=>x.Articles).Map(m =>
//            {
//    m.ToTable("Article_Tag");
//    m.MapLeftKey("ArticleId");
//    m.MapRightKey("TagId");
//});