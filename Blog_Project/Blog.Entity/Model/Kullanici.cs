using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Model
{
    public class Kullanici : IEntity
    {
        public Kullanici()
        {
            Makaleler = new HashSet<Makale>();
        }
        public int KullaniciId { get; set; }

        public int MakaleId { get; set; }

        public string Email { get; set; }

        public string Sifre { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public virtual ICollection<Makale> Makaleler{ get; set; }

    }
}
