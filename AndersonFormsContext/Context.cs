using AndersonFormsEntity;
using System.Data.Entity;
using AndersonCRMContext;
using AccountsEntity;
using AndersonFormsModel;

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

        public DbSet<EByod> Byods { get; set; }
        public DbSet<ETypeOfDevice> TypeOfDevices { get; set; }
        public DbSet<ERequestedItem> RequestedItems { get; set; }

    }
}
