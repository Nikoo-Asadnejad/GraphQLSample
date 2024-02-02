using Microsoft.AspNetCore.Mvc;
namespace GraphQl.Api.Queries;
public class Query
{
    public string Hello => "hello";
    // public UserDocument TestUser() => new UserDocument()
    // {
    //     Name = "nikoo",
    //     LastName = "asadnejad"
    // };
    // public async Task<List<UserDocument>> GetUsers([FromServices] IUserService service)
    //     => await service.GetList();
    // public async Task<UserDocument> GetUser(string id,[FromServices] IUserService service)
    //     => await service.Get(id);
}