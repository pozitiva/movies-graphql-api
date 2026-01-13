using Microsoft.EntityFrameworkCore;
using movies_graphql_api.Data;
using movies_graphql_api.Models;

namespace movies_graphql_api.GraphQL.Queries
{
    public class FilmQuery
    {
        public async Task<IEnumerable<Film>> GetAllFilms([Service] MoviesContext context)
        {
            return await context.Films
                .OrderBy(f => f.FilmId)
                .ToListAsync();
        }

        public async Task<Film?> GetFilmById(int id, [Service] MoviesContext context)
        {
            return await context.Films.FindAsync(id);
        }
    }
}

