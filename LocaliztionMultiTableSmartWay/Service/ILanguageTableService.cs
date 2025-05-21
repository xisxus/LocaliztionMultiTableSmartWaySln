using LocaliztionMultiTableSmartWay.ViewModel;

namespace LocaliztionMultiTableSmartWay.Service
{
    public interface ILanguageTableService
    {
        Task<bool> TableExistsWithIndReal(string languageCode);
        bool TableExistsWithIndRealNan(string languageCode);
        Task<string> GetTableNameWithInd(string languageCode);
        string GetTableNameWithIndNan(string languageCode);
        Task<string> GetTranslateWithInd(string tableName, string key);
        string GetTranslateWithIndNan(string tableName, string key);
        Task AddTableWithInd(string languageCode);
        Task SaveDataWithInd(TableDataIndDto model);
        Task<List<string>> GetLangInd();
        Task SaveBulkDataWithInd(List<TableDataIndDto> listDto);
        Task<List<CommonLanguageVM>> GetDataWithIndAsync(string languageCode);
        List<CommonLanguageVM> GetDataWithInd(string languageCode);
        List<CommonLanguageVM> GetTranslationsTableData(string languageCode);
        Task<CommonReturnViewModel> UpdateTranslateAsync(LanguageUpdateVM updateVM);
    }
}
