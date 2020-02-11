using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Model
{
    public class Yorum : IEntity
    {
        public int YorumId { get; set; }

        public int MakaleId { get; set; }

        public string AdSoyad { get; set; }

        public string YorumYazisi { get; set; }

        public DateTime YorumTarihi { get; set; }
    }
}