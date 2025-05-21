using LocaliztionMultiTableSmartWay.Service;
using Microsoft.AspNetCore.Mvc;

namespace LocaliztionMultiTableSmartWay.Controllers.BaseController
{
    public abstract class BaseNormalController : Controller
    {
        protected readonly ITranslateService _translateService;

        private int _pageCode;
        protected string LanguageCode => HttpContext.Items["Language"] as string ?? "en";


        protected BaseNormalController(ITranslateService translateService)
        {
            _translateService = translateService;
        }

        // Call this in each controller to set the correct pageCode
        protected void SetPageCode(int startCode)
        {
            _pageCode = startCode;
        }

        protected string Translate(string defaultText)
        {
            return _translateService.GetTranslationInd(defaultText, _pageCode++.ToString(), LanguageCode);
        }
    }
}
