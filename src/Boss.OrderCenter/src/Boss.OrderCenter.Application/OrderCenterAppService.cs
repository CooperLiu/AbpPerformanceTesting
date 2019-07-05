using Boss.OrderCenter.Localization;
using Volo.Abp.Application.Services;

namespace Boss.OrderCenter
{
    public abstract class OrderCenterAppService : ApplicationService
    {
        protected OrderCenterAppService()
        {
            LocalizationResource = typeof(OrderCenterResource);
        }
    }
}
