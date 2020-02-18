using Blog_Project_DAL.Database;
using Blog_Project_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project_DAL.Repository
{
    public class ArticleRepository
    {
        ProjectContext projectContext;

        public List<Article> GetArticles()
        {
            List<Article> ArticleList;

            using (projectContext = new ProjectContext())
            {
                ArticleList = projectContext.Articles.ToList();
            }

            return ArticleList;
        }

        public Article GetArticle(int id)
        {
            Article getArticle;

            using (projectContext= new ProjectContext())
            {
                getArticle = projectContext.Articles.FirstOrDefault(x => x.ArticleId == id);
            }

            return getArticle;
        }



    }
}
