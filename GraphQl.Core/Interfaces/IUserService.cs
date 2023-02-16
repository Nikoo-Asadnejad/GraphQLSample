using GraphQl.Core.Entities;

namespace GraphQl.Core.Interfaces;

public interface IUserService
{
    Task Create(UserDocument user);
    Task<UserDocument> Get(string objectId);
    Task<List<UserDocument>> GetList();
    Task Update(UserDocument user);
}