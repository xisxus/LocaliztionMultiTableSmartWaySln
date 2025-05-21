using LocaliztionMultiTableSmartWay.Controllers.BaseController;
using LocaliztionMultiTableSmartWay.Service;
using Microsoft.AspNetCore.Mvc;

namespace LocaliztionMultiTableSmartWay.Controllers
{
    public class NormalWayController : BaseNormalController
    {
        public NormalWayController(ITranslateService translateService) : base(translateService)
        {
        }

        public IActionResult Index()
        {
            SetPageCode(612000);
            return View();
        }
    }
}
