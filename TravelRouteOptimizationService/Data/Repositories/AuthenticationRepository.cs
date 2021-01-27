using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TravelRouteOptimizationService.Data.RepositoryImplementations;
using TravelRouteOptimizationService.Model;

namespace TravelRouteOptimizationService.Data.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly IConfiguration _config;
        public AuthenticationRepository(IConfiguration config) {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("MyConnectionString"));
            }
        }

        public async Task<User> GetUserByMailandPassword(string email, string password)
        {
            using (IDbConnection dbConnection = Connection)
            {

                const string sqlQuery = "Select_UserByEmailPassword";

                var result = await dbConnection.QueryFirstOrDefaultAsync<User>(sqlQuery,
                    new
                    {
                        Email = email,
                        Password = password
                    }, commandType: CommandType.StoredProcedure);

                return result;

            }
        }

        public async Task<bool> InsertUser(string name, string surname, string email, string password)
        {
            using (IDbConnection dbConnection = Connection)
            {

                const string sqlQuery = "Insert_User";

                var result = await dbConnection.ExecuteAsync(sqlQuery,
                    new
                    {
                        Name = name,
                        Surname = surname,
                        Email = email,
                        Password = password
                    }, commandType: CommandType.StoredProcedure);

                return result > 0;

            }
        }
    }
}
