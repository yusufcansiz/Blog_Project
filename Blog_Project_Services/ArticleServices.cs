using Blog_Project_DAL.Repository;
using Blog_Project_Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project_Services
{
    public class ArticleServices
    {
        private readonly ArticleRepository _articleRepository;
        private static int _rowNumber;

        public ArticleServices()
        {
            _articleRepository = new ArticleRepository();
            _rowNumber = Convert.ToInt32(ConfigurationManager.AppSettings["TopRowNumber"]);
        }


        public List<Article> GetArticles()
        {
            var Articles = _articleRepository.GetArticles();

            if (Articles == null)
                return null;

            return Articles;
        }

        public Article GetArticle(int id)
        {
            if (id == null && id < 0)
                return null;

            var Article = _articleRepository.GetArticle(id);

            if (Article == null)
                return null;
            
            return Article;
        }
        

    }
}
