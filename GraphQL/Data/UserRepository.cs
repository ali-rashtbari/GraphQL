using GraphQL.Data.Contracts;
using GraphQL.Data.Entities;
using System.Reflection.Metadata.Ecma335;

namespace GraphQL.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly IEnumerable<User> _users;
        public UserRepository()
        {
            _users =
            [
                new User { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", BirthDate = new DateOnly(1994, 4, 15) },
                new User { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", BirthDate = new DateOnly(1996, 2, 20) },
                new User { Id = 3, FirstName = "Michael", LastName = "Johnson", Email = "michael.johnson@example.com", BirthDate = new DateOnly(1989, 8, 10) },
                new User { Id = 4, FirstName = "Emily", LastName = "Davis", Email = "emily.davis@example.com", BirthDate = new DateOnly(1998, 12, 5) },
                new User { Id = 5, FirstName = "Daniel", LastName = "Martinez", Email = "daniel.martinez@example.com", BirthDate = new DateOnly(1984, 7, 22) },
                new User { Id = 6, FirstName = "Sarah", LastName = "Lopez", Email = "sarah.lopez@example.com", BirthDate = new DateOnly(1992, 3, 8) },
                new User { Id = 7, FirstName = "David", LastName = "Gonzalez", Email = "david.gonzalez@example.com", BirthDate = new DateOnly(1995, 6, 18) },
                new User { Id = 8, FirstName = "Jessica", LastName = "Wilson", Email = "jessica.wilson@example.com", BirthDate = new DateOnly(1997, 9, 14) },
                new User { Id = 9, FirstName = "James", LastName = "Anderson", Email = "james.anderson@example.com", BirthDate = new DateOnly(1996, 11, 30) },
                new User { Id = 10, FirstName = "Amanda", LastName = "Thomas", Email = "amanda.thomas@example.com", BirthDate = new DateOnly(1991, 1, 11) },
                new User { Id = 11, FirstName = "Robert", LastName = "Taylor", Email = "robert.taylor@example.com", BirthDate = new DateOnly(1985, 5, 23) },
                new User { Id = 12, FirstName = "Patricia", LastName = "Moore", Email = "patricia.moore@example.com", BirthDate = new DateOnly(1988, 10, 2) },
                new User { Id = 13, FirstName = "William", LastName = "Jackson", Email = "william.jackson@example.com", BirthDate = new DateOnly(1993, 3, 15) },
                new User { Id = 14, FirstName = "Elizabeth", LastName = "Martin", Email = "elizabeth.martin@example.com", BirthDate = new DateOnly(1990, 12, 20) },
                new User { Id = 15, FirstName = "Christopher", LastName = "Lee", Email = "christopher.lee@example.com", BirthDate = new DateOnly(1982, 11, 17) },
                new User { Id = 16, FirstName = "Linda", LastName = "Perez", Email = "linda.perez@example.com", BirthDate = new DateOnly(1994, 7, 6) },
                new User { Id = 17, FirstName = "Brian", LastName = "Thompson", Email = "brian.thompson@example.com", BirthDate = new DateOnly(1987, 8, 25) },
                new User { Id = 18, FirstName = "Barbara", LastName = "White", Email = "barbara.white@example.com", BirthDate = new DateOnly(1989, 9, 13) },
                new User { Id = 19, FirstName = "Richard", LastName = "Harris", Email = "richard.harris@example.com", BirthDate = new DateOnly(1992, 1, 29) },
                new User { Id = 20, FirstName = "Susan", LastName = "Clark", Email = "susan.clark@example.com", BirthDate = new DateOnly(1995, 6, 14) },
                new User { Id = 21, FirstName = "Charles", LastName = "Lewis", Email = "charles.lewis@example.com", BirthDate = new DateOnly(1983, 4, 3) },
                new User { Id = 22, FirstName = "Jessica", LastName = "Robinson", Email = "jessica.robinson@example.com", BirthDate = new DateOnly(1991, 2, 21) },
                new User { Id = 23, FirstName = "Joseph", LastName = "Walker", Email = "joseph.walker@example.com", BirthDate = new DateOnly(1985, 5, 28) },
                new User { Id = 24, FirstName = "Lisa", LastName = "Hall", Email = "lisa.hall@example.com", BirthDate = new DateOnly(1990, 11, 9) },
                new User { Id = 25, FirstName = "Steven", LastName = "Young", Email = "steven.young@example.com", BirthDate = new DateOnly(1984, 3, 19) },
                new User { Id = 26, FirstName = "Mary", LastName = "Allen", Email = "mary.allen@example.com", BirthDate = new DateOnly(1988, 7, 12) },
                new User { Id = 27, FirstName = "Paul", LastName = "King", Email = "paul.king@example.com", BirthDate = new DateOnly(1986, 9, 8) },
                new User { Id = 28, FirstName = "Karen", LastName = "Wright", Email = "karen.wright@example.com", BirthDate = new DateOnly(1983, 11, 3) },
                new User { Id = 29, FirstName = "Mark", LastName = "Scott", Email = "mark.scott@example.com", BirthDate = new DateOnly(1994, 12, 16) },
                new User { Id = 30, FirstName = "Nancy", LastName = "Torres", Email = "nancy.torres@example.com", BirthDate = new DateOnly(1992, 6, 11) },
                new User { Id = 31, FirstName = "George", LastName = "Hill", Email = "george.hill@example.com", BirthDate = new DateOnly(1986, 4, 20) },
                new User { Id = 32, FirstName = "Michelle", LastName = "Green", Email = "michelle.green@example.com", BirthDate = new DateOnly(1989, 10, 24) },
                new User { Id = 33, FirstName = "Edward", LastName = "Adams", Email = "edward.adams@example.com", BirthDate = new DateOnly(1993, 2, 27) },
                new User { Id = 34, FirstName = "Deborah", LastName = "Baker", Email = "deborah.baker@example.com", BirthDate = new DateOnly(1990, 1, 4) },
                new User { Id = 35, FirstName = "Kenneth", LastName = "Gonzalez", Email = "kenneth.gonzalez@example.com", BirthDate = new DateOnly(1985, 11, 19) },
                new User { Id = 36, FirstName = "Sandra", LastName = "Nelson", Email = "sandra.nelson@example.com", BirthDate = new DateOnly(1991, 7, 30) },
                new User { Id = 37, FirstName = "Eric", LastName = "Carter", Email = "eric.carter@example.com", BirthDate = new DateOnly(1992, 5, 2) },
                new User { Id = 38, FirstName = "Donna", LastName = "Mitchell", Email = "donna.mitchell@example.com", BirthDate = new DateOnly(1987, 6, 7) },
                new User { Id = 39, FirstName = "Ryan", LastName = "Perez", Email = "ryan.perez@example.com", BirthDate = new DateOnly(1990, 10, 25) },
                new User { Id = 40, FirstName = "Laura", LastName = "Roberts", Email = "laura.roberts@example.com", BirthDate = new DateOnly(1993, 3, 14) }
            ];
        }

        public IEnumerable<User> GetUsers() => _users;

    }
}
