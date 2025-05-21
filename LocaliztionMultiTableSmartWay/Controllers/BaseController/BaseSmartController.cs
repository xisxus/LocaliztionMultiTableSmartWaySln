using LocaliztionMultiTableSmartWay.Service;
using Microsoft.AspNetCore.Mvc;

namespace LocaliztionMultiTableSmartWay.Controllers.BaseController
{
    public abstract class BaseSmartController : Controller
    {
        protected readonly ITranslateService _translateService;

        private int _smartPageCode = 0;

        protected BaseSmartController(ITranslateService translateService)
        {
            _translateService = translateService;
        }

        protected void SetSmartPageCode(int code)
        {
            _smartPageCode = code;
            ViewData["SmartPageCode"] = _smartPageCode;
            ViewData["BaseControllerInstance"] = this;
        }

        protected string SmartLocalizeText(string defaultText)
        {
            string lang = HttpContext.Items["Language"] as string ?? "en";
            return _translateService.GetTranslationInd(defaultText, _smartPageCode++.ToString(), lang);
        }


    }
}
