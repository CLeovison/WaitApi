namespace WaitApi.Endpoints.UserEndpoints;


public class CreateUserEndpoint : IEndpoint{
    
    public void Endpoint(IEndpointRouteBuilder app){
        app.MapPost("/users/register", async() =>{

        });
    }
}