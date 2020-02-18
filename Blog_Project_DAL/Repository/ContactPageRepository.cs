using Blog_Project_DAL.Database;
using Blog_Project_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project_DAL.Repository
{
    public class ContactPageRepository
    {
        ProjectContext projectContext;

        public ContactPage GetContactPage()
        {
            ContactPage GetContactPage;

            using(projectContext = new ProjectContext())
            {
                GetContactPage = projectContext.ContactPage.FirstOrDefault();
            }

            return GetContactPage;
        }
    }
}
