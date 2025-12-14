using movies_graphql_api.Data;
using movies_graphql_api.GraphQL.Mutations;
using movies_graphql_api.GraphQL.Queries;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MoviesContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("SakilaDb")));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<FilmQuery>()
    .AddMutationType<FilmMutation>();

var app = builder.Build();

app.MapGraphQL("/graphql");

app.Run();
