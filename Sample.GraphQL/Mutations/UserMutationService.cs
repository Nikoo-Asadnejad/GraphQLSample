using Microsoft.AspNetCore.Connections;

namespace Sample.GraphQL.Mutations;

public class UserMutationService
{
    public async Task<UserMutation> AddUser(UserMutation user)
    {
        return user;
    }
}