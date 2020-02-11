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
    public class KategoriRepository : EFRepositoryBase<Kategori, int, ETicaretContext>, IKategoriRepository
    {
        public KategoriRepository() : base(new ETicaretContext())
        {

        }
    }
}
