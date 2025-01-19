using WaitApi.Abstract;
using WaitApi.Services.UserServices;

namespace WaitApi.Endpoints.UserEndpoints;


public class ForgotUserPasswordEndpoint(IUserService service) : IEndpoint{
    

    public void Endpoint(IEndpointRouteBuilder app){

    }
}