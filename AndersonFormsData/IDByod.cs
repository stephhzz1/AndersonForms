using AndersonFormsEntity;
using BaseData;

namespace AndersonFormsData
{
    public interface IDByod : IDBase
    {
        EByod Approve(EByod eByod);
    }
}
