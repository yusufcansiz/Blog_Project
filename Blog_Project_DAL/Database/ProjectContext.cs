using Blog_Project_DAL.Mapping;
using Blog_Project_Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Blog_Project_DAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Configuration.LazyLoadingEnabled = false;
            //Database.Connection.ConnectionString = @"Server=;Database=;Uid=;Pwd=;";

            var value = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<AboutPage> AboutPage { get; set; }

        public DbSet<ContactPage> ContactPage { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ArticleMappings());

        }
    }
}
