using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Model
{
    public class Etiket : IEntity
    {
        public int EtiketId { get; set; }

        public string EtiketAdi { get; set; }

        public string Detay { get; set; }
    }
}
