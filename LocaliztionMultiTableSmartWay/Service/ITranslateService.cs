namespace LocaliztionMultiTableSmartWay.Service
{
    public interface ITranslateService
    {
        Task<string> GetTranslationAsyncInd(string key, string code, string languageCode);
        string GetTranslationInd(string key, string code, string languageCode);
    }
}
