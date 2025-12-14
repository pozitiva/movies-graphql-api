using movies_graphql_api.Data;
using movies_graphql_api.Models;

namespace movies_graphql_api.GraphQL.Queries
{
    public class FilmQuery
    {
        // 1. Vrati sve filmove
        public IQueryable<Film> GetFilms([Service] MoviesContext context)
            => context.Films;

        // 2. Vrati film po ID-ju
        public Film? GetFilmById(
            int id,
            [Service] MoviesContext context)
            => context.Films.FirstOrDefault(f => f.FilmId == id);
    }
}

