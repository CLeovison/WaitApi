using WaitApi.Abstract;
using WaitApi.Services.UserServices;
using WaitApi.Contracts.Request.UserRequest;
using WaitApi.Mapping;

namespace WaitApi.Endpoints.UserEndpoints;

//Instead of Using A Traditional Constructor, I use Primary Constructor to declare the Service Collection

//Traditional Constructor Looks Like
//  private readonly IUserService _userService;
// 
// public CreateUserEndpoint(IUserService userService){ 
//      _userService = userService.
// }
// 

//A Primary Constructor Looks like this, public class CreateUserEndpoint(IUserService userService)

public class CreateUserEndpoint(IUserService userService) : IEndpoint
{

    public void Endpoint(IEndpointRouteBuilder app)
    {

        app.MapPost("/users/register", async (RegisterUserRequest req, CancellationToken ct) =>
         {
             var user = req.ToCreateUser();

             await userService.RegisterUserAsync(user);

         });
    }
}