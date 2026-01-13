namespace movies_graphql_api.GraphQL.Inputs
{
    public class UpdateFilmInput
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public int? ReleaseYear { get; set; }

    }
}
