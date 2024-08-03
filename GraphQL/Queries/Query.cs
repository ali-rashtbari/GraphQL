using GraphQL.Data.Contracts;
using GraphQL.Data.Entities;

namespace GraphQL.Queries
{
    public class Query(IUserRepository _userRepository)
    {
        public IEnumerable<User> GetUsers(string firstName, string lastName)
        {
            var users = _userRepository.GetUsers();

            if (!string.IsNullOrEmpty(firstName))
            {
                users = users.Where(u => u.FirstName.Contains(firstName, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(lastName))
            {
                users = users.Where(u => u.LastName.Contains(lastName, StringComparison.OrdinalIgnoreCase));
            }

            return users;

        }
    }
}
