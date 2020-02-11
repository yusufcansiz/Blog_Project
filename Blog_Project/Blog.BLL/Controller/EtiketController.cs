using Blog.BLL.IServices;
using Blog.BLL.Services;
using Blog.Core.DataAccess.IBaseRepository;
using Blog.DAL.Repositories;
using Blog.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Controller
{
    public class EtiketController :Services.ServicesBase<Etiket, int>, IEtiketServices
    {
        public EtiketController() : base(new EtiketRepository())
        {

        }

    }
}
