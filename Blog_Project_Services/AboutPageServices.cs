using Blog_Project_DAL.Repository;
using Blog_Project_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project_Services
{
    public class AboutPageServices
    {
        private readonly AboutPageRepository _aboutPageRepository;

        public AboutPageServices()
        {
            _aboutPageRepository = new AboutPageRepository();
        }

        public AboutPage GetAboutPage()
        {
            var getAboutPage = _aboutPageRepository.GetAboutPage();
            return getAboutPage;
        }

    }
}
