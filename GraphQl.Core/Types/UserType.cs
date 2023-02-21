using GraphQl.Core.Entities;
using HotChocolate.Types;

namespace GraphQl.Core.Types;
public class UserType  : ObjectType<UserDocument>
{
    public UserType(IObjectTypeDescriptor<UserDocument> descriptor)
    {
        descriptor.Field(u => u.Name + u.LastName).Description("user full name");
        descriptor.Field(u => u.Id).Description("user id");
        descriptor.Field(u => u.Age).Description("user age");
    }
}