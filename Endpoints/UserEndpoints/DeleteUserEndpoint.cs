using WaitApi.Abstract;
using WaitApi.Services.UserServices;

namespace WaitApi.Endpoints.UserEndpoints;


public class DeleteUserEndpoint(IUserService service) : IEndpoint{

    public void Endpoint(IEndpointRouteBuilder app){

    }

}