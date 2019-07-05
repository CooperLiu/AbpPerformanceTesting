using Boss.OrderCenter.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Boss.OrderCenter
{
    public abstract class OrderCenterController : AbpController
    {
        protected OrderCenterController()
        {
            LocalizationResource = typeof(OrderCenterResource);
        }
    }
}
