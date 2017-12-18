    using AndersonFormsContext;
using AndersonFormsEntity;
using BaseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonFormsData
{
    public class DRequestedItem : DBase, IDRequestedItem
    {
        public DRequestedItem() : base(new Context())
        {
        }

        public List<ERequestedItem> Read()
        {
            using (var context = new Context())
            {
                return context.RequestedItems

                    .ToList();
            }
        }
    }
}
