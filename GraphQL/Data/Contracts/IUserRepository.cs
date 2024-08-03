using GraphQL.Data.Entities;

namespace GraphQL.Data.Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}
