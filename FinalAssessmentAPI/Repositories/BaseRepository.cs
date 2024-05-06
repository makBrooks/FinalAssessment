using System.Data.SqlClient;

namespace FinalAssessmentAPI.Repositories
{
    public class BaseRepository
    {
        private readonly IConfiguration _configuration;

        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected SqlConnection Connection()
        {
            return new SqlConnection(_configuration.GetConnectionString("MyConnection"));
        }
    }
}
