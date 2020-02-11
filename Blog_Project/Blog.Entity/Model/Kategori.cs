using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Model
{
    public class Kategori : IEntity
    {
        public int KategoriId { get; set; }

        public string KategoriAdi { get; set; }

        public int UstKategoriId { get; set; }
    }
}
