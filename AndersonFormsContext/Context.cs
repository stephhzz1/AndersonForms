using AndersonCRMModel;
using AndersonFormsEntity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AndersonFormsContext
{

    public class Context : DbContext
    {

        public Context() : base("AndersonForms")
        {
            if (Database.Exists())
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>());
            }
            else
            {
                Database.SetInitializer(new DBInitializer());
            }

        }

        //Added code
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }



        public DbSet<EByod> Byods { get; set; }
        public DbSet<EChecklist> Checklists { get; set; }
        public DbSet<ERequestedItem> RequestedItems { get; set; }
        public DbSet<ETypeOfDevice> TypeOfDevices { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
   
}
