using System;
using AndersonFormsContext;
using AndersonFormsEntity;
using BaseData;

namespace AndersonFormsData
{
    public class DByod : DBase, IDByod
    {
        public DByod() : base(new Context())
        {
        }

        public EByod Approve(EByod eByod)
        {
            throw new NotImplementedException();
        }
    }
}
