using AndersonFormsEntity;
using BaseData;
using System.Collections.Generic;

namespace AndersonFormsData
{
    public interface IDRequestedItem : IDBase
    {
        List<ERequestedItem> Read();
    }
}
