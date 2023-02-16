using MongoRepository.Atrributes;
using MongoRepository.Models;

namespace GraphQl.Core.Entities;

[MongoCollection("Users")]
public class UserDocument : MongoDocument
{
    public string Name { get; set; }
    public  string LastName { get; set; }
    public int Age { get; set; }
}