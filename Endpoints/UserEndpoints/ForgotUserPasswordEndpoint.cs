
using WaitApi.Abstract;
using WaitApi.Contracts.Request.UserRequest;
using WaitApi.Services.UserServices;

namespace WaitApi.Endpoints.UserEndpoints;


public class ForgotUserPasswordEndpoint(IUserService service) : IEndpoint
{


    public void Endpoint(IEndpointRouteBuilder app)
    {

        app.MapGet("/users/forgot-password", async (ForgotUserPasswordRequest req) =>
        {
         


        });

    }
}