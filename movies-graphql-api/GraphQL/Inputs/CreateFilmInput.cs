namespace movies_graphql_api.GraphQL.Inputs
{
    public class CreateFilmInput
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public int? ReleaseYear { get; set; }
        public int LanguageId { get; set; }
        public int RentalDuration { get; set; }
        public decimal RentalRate { get; set; }
        public int? Length { get; set; }
        public decimal ReplacementCost { get; set; }

    }
}
