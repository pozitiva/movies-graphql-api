using movies_graphql_api.Data;
using movies_graphql_api.GraphQL.Inputs;
using movies_graphql_api.Models;

namespace movies_graphql_api.GraphQL.Mutations
{
    public class FilmMutation
    {
        public async Task<Film> CreateFilm(CreateFilmInput input, [Service] MoviesContext context)
        {
            var film = new Film
            {
                Title = input.Title,
                Description = input.Description,
                ReleaseYear = input.ReleaseYear,
                LanguageId = input.LanguageId,
                RentalDuration = input.RentalDuration,
                RentalRate = input.RentalRate,
                Length = input.Length,
                ReplacementCost = input.ReplacementCost,
                LastUpdate = DateTime.UtcNow
            };

            context.Films.Add(film);
            await context.SaveChangesAsync();

            return film;
        }


       public async Task<Film?> UpdateFilm(int id, UpdateFilmInput input, [Service] MoviesContext context)
        {
            var film = await context.Films.FindAsync(id);

            if (film == null)
                return null;

            film.Title = input.Title;
            film.Description = input.Description;
            film.ReleaseYear = input.ReleaseYear;
            film.LastUpdate = DateTime.UtcNow;

            await context.SaveChangesAsync();
            return film;
        }

        public async Task<bool> DeleteFilm(int id, [Service] MoviesContext context)
        {
            var film = await context.Films.FindAsync(id);

            if (film == null)
                return false;

            context.Films.Remove(film);
            await context.SaveChangesAsync();
            return true;
        }
    }
}

