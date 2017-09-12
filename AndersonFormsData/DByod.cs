using AndersonFormsContext;
using BaseData;

namespace AndersonFormsData
{
    public class DByod : DBase, IDByod
    {
        public DByod() : base(new Context())
        {
        }
    }
}
