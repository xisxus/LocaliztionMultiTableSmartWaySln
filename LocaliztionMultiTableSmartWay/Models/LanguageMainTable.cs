namespace LocaliztionMultiTableSmartWay.Models
{
    public class LanguageMainTable
    {
        public int Id { get; set; }

        public string TextCode { get; set; }

        public string EnglishText { get; set; }

        public bool IsModified { get; set; }
    }
}
