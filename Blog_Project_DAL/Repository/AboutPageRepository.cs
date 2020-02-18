using Blog_Project_DAL.Database;
using Blog_Project_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project_DAL.Repository
{
    public class AboutPageRepository
    {
        ProjectContext projectContext;
        
        public AboutPage GetAboutPage()
        {
            AboutPage GetAboutPage;
            using (projectContext = new ProjectContext())
            {
                GetAboutPage = projectContext.AboutPage.FirstOrDefault();
            }
            return GetAboutPage;
        }

    }
}
