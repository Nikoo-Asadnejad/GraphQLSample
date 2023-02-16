using GraphQl.Core.Entities;
using GraphQl.Core.Interfaces;
using MongoDB.Bson;
using MongoRepository.Repository;

namespace GraphQl.Infrastructure.Services;

public class UserService : IUserService
{
    private IMongoRepository<UserDocument> _repository;
    public UserService(IMongoRepository<UserDocument> repository)
    {
        _repository = repository;
    }
    public async Task Create(UserDocument user)
    {
        await _repository.InsertAsync(user);
    }
    public async Task<UserDocument> Get(string objectId)
    {
        return await _repository.FindByIdAsync(objectId);
    }
    public async  Task<List<UserDocument>> GetList()
    {
        return await _repository.FilterByAsync(u => true);
    }
    public async  Task Update(UserDocument user)
    {
        await _repository.ReplaceOneAsync(user);
    }
}