using Blog_Project_Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project_DAL.Mapping
{
    public class ArticleMappings : EntityTypeConfiguration<Article>
    {
        public ArticleMappings() 
        {
            ToTable("Article");
            HasKey(x => x.ArticleId);
            Property(x => x.ArticleDate).HasColumnType("Datetime");
            Property(x => x.ArticleContent).HasColumnType("text");
            Property(x => x.ArticleClick).HasColumnType("int");

        }
    }
}
