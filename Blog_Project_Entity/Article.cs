using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project_Entity
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string ArticleTitle { get; set; }

        public string ArticleContent { get; set; }

        public string ArticleImagePath { get; set; }

        public string ArticleDescription { get; set; }

        public DateTime ArticleDate { get; set; }

        public int ArticleClick { get; set; }

        public string ArticleCategory { get; set; }

        public string ArticleTag { get; set; }
    }
}
