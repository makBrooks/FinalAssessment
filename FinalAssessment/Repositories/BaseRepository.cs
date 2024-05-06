using System.Data;
using System.Data.SqlClient;

namespace FinalAssessment.Repositories
{
    public class BaseRepository
    {
        private readonly IConfiguration _configuration;

        protected BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected SqlConnection Connection()
        {
            return new SqlConnection(_configuration.GetConnectionString("MyConnection"));
        }
    }
}
