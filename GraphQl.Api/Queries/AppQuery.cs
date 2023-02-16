using GraphQl.Core.Entities;
using GraphQl.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace GraphQl.Api.Queries;
public class AppQuery
{
    public async Task<List<UserDocument>> GetUsers([FromServices] IUserService service)
        => await service.GetList();
    public async Task<UserDocument> GetUser(string id,[FromServices] IUserService service)
        => await service.Get(id);
}