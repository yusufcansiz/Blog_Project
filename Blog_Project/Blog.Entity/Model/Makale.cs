using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Model
{
    public class Makale : IEntity
    {
        public int MakaleId { get; set; }

        public int KullaniciId { get; set; }

        public string Baslik { get; set; }

        public string Ozet { get; set; }

        public string Yazi { get; set; }

        public DateTime YazimTarihi { get; set; }

        public int BegenmeSayisi { get; set; }

        public int GoruntulemeSayisi { get; set; }
    }
}
