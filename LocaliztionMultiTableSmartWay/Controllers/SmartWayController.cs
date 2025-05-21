using LocaliztionMultiTableSmartWay.Controllers.BaseController;
using LocaliztionMultiTableSmartWay.Service;
using Microsoft.AspNetCore.Mvc;

namespace LocaliztionMultiTableSmartWay.Controllers
{
    public class SmartWayController : BaseSmartController
    {
        public SmartWayController(ITranslateService translateService) : base(translateService)
        {
        }

        public IActionResult Index()
        {
            SetSmartPageCode(912000);

            return View();
        }
    }
}
