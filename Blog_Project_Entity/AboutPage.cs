using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blog_Project_Entity
{
    public class AboutPage
    {
        [Key]
        public int AboutPageId { get; set; }

        public string TitleName { get; set; }

        public string AboutDescription { get; set; }
    }
}
