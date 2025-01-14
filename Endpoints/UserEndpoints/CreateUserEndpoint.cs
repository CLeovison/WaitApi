using WaitApi.Abstract;

using Npgsql;
using Dapper;
using WaitApi.Contracts.Data;

namespace WaitApi.Endpoints.UserEndpoints;


public class CreateUserEndpoint : IEndpoint
{

    public void Endpoint(IEndpointRouteBuilder app)
    {


        app.MapPost("/users/register", async (IConfiguration configuration, UserDto user) =>
         {
            
        });
    }
}