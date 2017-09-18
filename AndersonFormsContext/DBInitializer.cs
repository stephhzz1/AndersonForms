using AndersonFormsEntity;
using System.Data.Entity;

namespace AndersonFormsContext
{
    public class DBInitializer : CreateDatabaseIfNotExists<Context>
    {
        public DBInitializer()
        {
        }
        protected override void Seed(Context context)
        {
            ETypeOfDevice eTypeOfDevice = new ETypeOfDevice
            {
                Name = "Mobile Phone"
            };
            context.TypeOfDevices.Add(eTypeOfDevice);
            eTypeOfDevice.Name = "Laptop";
            context.TypeOfDevices.Add(eTypeOfDevice);

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
