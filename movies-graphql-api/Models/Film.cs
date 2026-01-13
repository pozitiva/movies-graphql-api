using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace movies_graphql_api.Models
{
    [Table("film")]
    public class Film
    {
        [Key]
        [Column("film_id")]
        public int FilmId { get; set; }

        [Column("title")]
        [Required]
        public string Title { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("release_year")]
        public int? ReleaseYear { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

        [Column("rental_duration")]
        public int RentalDuration { get; set; }

        [Column("rental_rate")]
        public decimal RentalRate { get; set; }

        [Column("length")]
        public int? Length { get; set; }

        [Column("replacement_cost")]
        public decimal ReplacementCost { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
