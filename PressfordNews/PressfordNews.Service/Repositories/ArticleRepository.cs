using System.Collections.Generic;
using System.Linq;

namespace PressfordNews.Service.Repositories
{
    public class ArticleRepository
    {
        private PressfordNewsContext _context;

        public ArticleRepository(PressfordNewsContext context)
        {
            this._context = context;
        }

        public IEnumerable<Article> LoadArticles()
        {
            IEnumerable<Article> articles;
            articles = _context.Articles;

            return articles;
        }

        public Article LoadById(int id)
        {
            Article article = null;
            if (id > 0)
            {
                article = _context.Articles
                    .Where(x => x.Id == id).FirstOrDefault();
            }

            return article;
        }

    }
}