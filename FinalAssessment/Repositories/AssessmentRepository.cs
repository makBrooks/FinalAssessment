using Dapper;
using FinalAssessment.Models;
using System.Data;

namespace FinalAssessment.Repositories
{
    public class AssessmentRepository : BaseRepository, IAssessmentRepository
    {
#pragma warning disable
        public AssessmentRepository(IConfiguration configuration) : base(configuration)
        {

        }
        //public async Task<List<AssessmentEntity>> BindBatch()
        //{
        //    try
        //    {
        //        var con = Connection();
        //        if (con.State == ConnectionState.Closed) con.Open();
        //        DynamicParameters param = new DynamicParameters();
        //        param.Add("@Mode", "bindbatch");
        //        var result = await con.QueryAsync<AssessmentEntity>("Usp_EmployeeGrade", param, commandType: System.Data.CommandType.StoredProcedure);
        //        if (result.Count() > 0)
        //        {
        //            return result.ToList();
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public async Task<List<AssessmentEntity>> BindTechnology()
        //{
        //    try
        //    {
        //        var con = Connection();
        //        if (con.State == ConnectionState.Closed) con.Open();
        //        DynamicParameters param = new DynamicParameters();
        //        param.Add("@Mode", "bindtechnology");
        //        var result = await con.QueryAsync<AssessmentEntity>("Usp_EmployeeGrade", param, commandType: System.Data.CommandType.StoredProcedure);
        //        if (result.Count() > 0)
        //        {
        //            return result.ToList();
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public async Task<List<AssessmentEntity>> BindEmployee(AssessmentEntity obj)
        //{
        //    try
        //    {
        //        var con = Connection();
        //        if (con.State == ConnectionState.Closed) con.Open();
        //        DynamicParameters param = new DynamicParameters();
        //        param.Add("@Mode", "bindempname");
        //        param.Add("@BatchId", obj.TechnologyId);
        //        var result = await con.QueryAsync<AssessmentEntity>("Usp_EmployeeGrade", param, commandType: System.Data.CommandType.StoredProcedure);
        //        if (result.Count() > 0)
        //        {
        //            return result.ToList();
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public async Task<List<AssessmentEntity>> GetDetailsByID(AssessmentEntity obj)
        //{
        //    try
        //    {
        //        var con = Connection();
        //        if (con.State == ConnectionState.Closed) con.Open();
        //        DynamicParameters param = new DynamicParameters();
        //        param.Add("@Mode", "batchdetails");
        //        param.Add("@BatchId", obj.BatchId);
        //        var result = await con.QueryAsync<AssessmentEntity>("Usp_EmployeeGrade", param, commandType: System.Data.CommandType.StoredProcedure);
        //        if (result.Count() > 0)
        //        {
        //            return result.ToList();
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public async Task<int> Insert(AssessmentEntity obj)
        //{
        //    try
        //    {
        //        var con = Connection();
        //        if (con.State == ConnectionState.Closed) con.Open();
        //        DynamicParameters param = new DynamicParameters();
        //        param.Add("@Mode", "insert");
        //        param.Add("@EmployeeId", obj.EmployeeId);
        //        param.Add("@mark", obj.mark);
        //        param.Add("@BatchId", obj.BatchId);
        //        param.Add("@TechnologyId", obj.TechnologyId);
        //        var result = await con.ExecuteAsync("Usp_EmployeeGrade", param, commandType: System.Data.CommandType.StoredProcedure);
        //        con.Close();
        //        return Convert.ToInt32(result);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public async Task<List<AssessmentEntity>> GetAll()
        //{
        //    try
        //    {
        //        var con = Connection();
        //        if (con.State == ConnectionState.Closed) con.Open();
        //        DynamicParameters param = new DynamicParameters();
        //        param.Add("@Mode", "display");
        //        var result = await con.QueryAsync<AssessmentEntity>("Usp_EmployeeGrade", param, commandType: System.Data.CommandType.StoredProcedure);
        //        if (result.Count() > 0)
        //        {
        //            return result.ToList();
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
