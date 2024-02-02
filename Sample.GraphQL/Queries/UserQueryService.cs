namespace Sample.GraphQL.Queries;

public class UserQueryService
{
    public UserQuery GetUser() => new UserQuery("nikoo" , "asadnejad" , "09110982234");
}