using movies_graphql_api.Models;

namespace movies_graphql_api.Dto
{
    public class PagedFilmsResult
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public List<Film> Data { get; set; } = new();
    }
}
