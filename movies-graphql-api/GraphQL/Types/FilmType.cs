using movies_graphql_api.Models;

public class FilmType : ObjectType<Film>
{
    protected override void Configure(IObjectTypeDescriptor<Film> descriptor)
    {
        descriptor.Field(f => f.FilmId).Type<NonNullType<IdType>>();
        descriptor.Field(f => f.Title).Type<NonNullType<StringType>>();
    }
}