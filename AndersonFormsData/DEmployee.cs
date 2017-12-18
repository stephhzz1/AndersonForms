using BaseData;
using AndersonFormsContext;
namespace AndersonFormsData
{
    public class DEmployee : DBase, IDEmployee
    {
        public DEmployee() : base(new Context())
        {
        }
    }
}