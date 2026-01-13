using Microsoft.EntityFrameworkCore;
using movies_graphql_api.Data;
using movies_graphql_api.Dto;
using movies_graphql_api.Models;

namespace movies_graphql_api.GraphQL.Queries
{
    public class FilmQuery
    {
        public async Task<PagedFilmsResult> GetAllFilms(
            [Service] MoviesContext context,
            int page = 1,
            int pageSize = 10)
        {
            if (page < 1 || pageSize < 1)
                throw new GraphQLException("Page and pageSize must be greater than 0.");

            var totalCount = await context.Films.CountAsync();

            var films = await context.Films
                .OrderBy(f => f.FilmId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedFilmsResult
            {
                Page = page,
                PageSize = pageSize,
                TotalCount = totalCount,
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize),
                Data = films
            };
        }

        public async Task<Film?> GetFilmById(int id, [Service] MoviesContext context)
        {
            return await context.Films.FindAsync(id);
        }
    }
}

