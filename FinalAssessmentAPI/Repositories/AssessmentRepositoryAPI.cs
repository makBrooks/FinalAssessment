using Dapper;
using FinalAssessment.Models;
using FinalAssessment.Repositories;
using System.Data;

namespace FinalAssessmentAPI.Repositories
{
    public class AssessmentRepositoryAPI: BaseRepository, IAssessmentRepositoryAPI
    {
        public AssessmentRepositoryAPI(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<List<AssessmentEntity>> BindCust()
        {
            try
            {
                var con = Connection();
                if (con.State == ConnectionState.Closed) con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Mode", "bindcust");
                var result = await con.QueryAsync<AssessmentEntity>("sp_OdrerManagement", param, commandType: System.Data.CommandType.StoredProcedure);
                if (result.Count() > 0)
                {
                    return result.ToList();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<AssessmentEntity>> BindSubcat(AssessmentEntity obj)
        {
            try
            {
                var con = Connection();
                if (con.State == ConnectionState.Closed) con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@mode", "bindsubcat");
                param.Add("@catid", obj.catid);
                var result = await con.QueryAsync<AssessmentEntity>("sp_OdrerManagement", param, commandType: System.Data.CommandType.StoredProcedure);
                if (result.Count() > 0)
                {
                    return result.ToList();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<AssessmentEntity>> Binditem(AssessmentEntity obj)
        {
            try
            {
                var con = Connection();
                if (con.State == ConnectionState.Closed) con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@mode", "binditem");
                param.Add("@subcatid", obj.subcatid);
                var result = await con.QueryAsync<AssessmentEntity>("sp_OdrerManagement", param, commandType: System.Data.CommandType.StoredProcedure);
                if (result.Count() > 0)
                {
                    return result.ToList();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<int> InsertSalesMaster(AssessmentEntity obj)
        {
            try
            {
                var con = Connection();
                if (con.State == ConnectionState.Closed) con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@mode", "inssalesmaster");
                param.Add("@custid", obj.custid);
                var result = await con.ExecuteAsync("sp_OdrerManagement", param, commandType: System.Data.CommandType.StoredProcedure);
                con.Close();
                return Convert.ToInt32(result);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> InsertSalesSlave(AssessmentEntity obj)
        {
            try
            {
                var con = Connection();
                if (con.State == ConnectionState.Closed) con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@mode", "inssalesslave");
                param.Add("@itemid", obj.itemid);
                param.Add("@qty", obj.qty);
                param.Add("@subcatid", obj.subcatid);
                var result = await con.ExecuteAsync("sp_OdrerManagement", param, commandType: System.Data.CommandType.StoredProcedure);
                con.Close();
                return Convert.ToInt32(result);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<AssessmentEntity>> GetAllbyLastOrderno()
        {
            try
            {
                var con = Connection();
                if (con.State == ConnectionState.Closed) con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@mode", "display");
                var result = await con.QueryAsync<AssessmentEntity>("sp_OdrerManagement", param, commandType: System.Data.CommandType.StoredProcedure);
                if (result.Count() > 0)
                {
                    return result.ToList();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
