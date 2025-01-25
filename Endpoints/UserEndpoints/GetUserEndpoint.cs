using WaitApi.Abstract;
using WaitApi.Services.UserServices;

namespace WaitApi.Endpoints.UserEndpoints;


public class GetUserEndpoint(IUserService service) : IEndpoint
{


    public void Endpoint(IEndpointRouteBuilder app)
    {

    }
}