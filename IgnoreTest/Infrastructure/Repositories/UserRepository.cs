using System.Collections.Generic;
using Dapper;
using Npgsql;

public class UserRepository
    {
        private NpgsqlConnection Connection {get; set;}

        public UserRepository(NpgsqlConnection connection)
        {
            Connection = connection;
        }

        public IEnumerable<StudioCodeTest.Infrastructure.POCOS.User> Users()
        {
            return Connection.Query<StudioCodeTest.Infrastructure.POCOS.User>("select *, \"e-mail\" as email from \"JesseLabb\".privat.\"User\"");
        }
    }
