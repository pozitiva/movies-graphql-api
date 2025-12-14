using Microsoft.EntityFrameworkCore;
using movies_graphql_api.Models;

namespace movies_graphql_api.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Films => Set<Film>();
    }
}
