using Microsoft.EntityFrameworkCore;
using movies_graphql_api.Data;
using movies_graphql_api.GraphQL.Mutations;
using movies_graphql_api.GraphQL.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MoviesContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("SakilaDb")));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<FilmQuery>()
    .AddMutationType<FilmMutation>()
    .AddType<FilmType>();

var app = builder.Build();

app.MapGraphQL("/graphql");

app.Run();
