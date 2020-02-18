using Blog_Project_DAL.Repository;
using Blog_Project_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project_Services
{
    public class ContactPageServices
    {
        private readonly ContactPageRepository _contactPageRepository;

        public ContactPageServices()
        {
            _contactPageRepository = new ContactPageRepository();
        }

        public ContactPage GetContactPage()
        {
            var getContactPage = _contactPageRepository.GetContactPage();
            return getContactPage;
        }

    }
}
