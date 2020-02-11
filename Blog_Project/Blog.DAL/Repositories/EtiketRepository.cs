using Blog.Core.DataAccess.BaseClass.EntityFramework;
using Blog.DAL.IRepositories;
using Blog.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
    public class EtiketRepository : EFRepositoryBase<Etiket, int, ETicaretContext>, IEtiketRepository
    {
        public EtiketRepository() : base(new ETicaretContext())
        {

        }
    }
}
