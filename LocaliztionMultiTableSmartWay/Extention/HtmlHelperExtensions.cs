using LocaliztionMultiTableSmartWay.Service;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LocaliztionMultiTableSmartWay.Extention
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlContent Translate(this IHtmlHelper htmlHelper, string defaultText, string pageCode = "000000")
        {
            var context = htmlHelper.ViewContext.HttpContext;
            var translateService = context.RequestServices.GetService<ITranslateService>();

            string language = context.Items["Language"] as string ?? "en";

            var translated = translateService?.GetTranslationInd(defaultText, pageCode, language) ?? defaultText;

            return new HtmlString(translated);
        }
    }
}
