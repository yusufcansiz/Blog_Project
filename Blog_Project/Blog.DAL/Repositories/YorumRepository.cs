using Blog.Core.DataAccess.BaseClass.EntityFramework;
using Blog.DAL.IRepositories;
using Blog.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
    public class YorumRepository : EFRepositoryBase<Yorum, int, ETicaretContext>, IYorumRepository
    {
        public YorumRepository() : base(new ETicaretContext())
        {

        }
    }
}
