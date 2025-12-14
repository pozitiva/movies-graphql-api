using movies_graphql_api.Data;
using movies_graphql_api.Models;

namespace movies_graphql_api.GraphQL.Mutations
{
    public class FilmMutation
    {
        // 3. Kreiraj novi film
        public async Task<Film> CreateFilm(
            Film film,
            [Service] MoviesContext context)
        {
            context.Films.Add(film);
            await context.SaveChangesAsync();
            return film;
        }

        // 4. Ažuriraj film
        public async Task<Film?> UpdateFilm(
            int id,
            Film input,
            [Service] MoviesContext context)
        {
            var film = await context.Films.FindAsync(id);
            if (film == null)
                return null;

            film.Title = input.Title;
            film.Description = input.Description;
            film.ReleaseYear = input.ReleaseYear;
            film.RentalRate = input.RentalRate;
            film.Length = input.Length;
            film.ReplacementCost = input.ReplacementCost;
            film.LastUpdate = DateTime.UtcNow;

            await context.SaveChangesAsync();
            return film;
        }

        // 5. Obriši film
        public async Task<bool> DeleteFilm(
            int id,
            [Service] MoviesContext context)
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

