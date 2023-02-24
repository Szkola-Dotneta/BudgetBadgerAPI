namespace BudgetBadgerWebApi.Api.Filters.Common
{
    public class DetailedInformationObject
    {
        public string Title { get; set; }
        public List<string> Details { get; set; }

        public DetailedInformationObject(string title)
        {
            Title = title;
            Details = new List<string>();
        }

        public DetailedInformationObject(string title, string detail) : this(title) => Details.Add(detail);

        public DetailedInformationObject(string title, List<string> details) : this(title) => Details = details;
    }
}
