using FinalAssessment.Models;

namespace FinalAssessmentAPI.Repositories
{
    public interface IAssessmentRepositoryAPI
    {
        public Task<List<AssessmentEntity>> BindCust();
        public Task<List<AssessmentEntity>> BindSubcat(AssessmentEntity obj);
        public Task<List<AssessmentEntity>> Binditem(AssessmentEntity obj);
        public Task<int> InsertSalesMaster(AssessmentEntity obj);
        public Task<int> InsertSalesSlave(AssessmentEntity obj);
        public Task<List<AssessmentEntity>> GetAllbyLastOrderno();
    }
}
