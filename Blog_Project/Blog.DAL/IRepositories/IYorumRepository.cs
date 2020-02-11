using Blog.Core.DataAccess.IBaseRepository;
using Blog.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.IRepositories
{
    public interface IYorumRepository : IRepository<Yorum, int>
    {
    }
}
