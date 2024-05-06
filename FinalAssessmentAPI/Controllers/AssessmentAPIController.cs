using FinalAssessment.Models;
using FinalAssessmentAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalAssessmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessmentAPIController : ControllerBase
    {
        private readonly IAssessmentRepositoryAPI _assessment;
        public AssessmentAPIController(IAssessmentRepositoryAPI assessment)
        {
            _assessment = assessment;
        }
        [HttpPost("BindCust")]
        public async Task<IActionResult> BindCust(AssessmentEntity obj)
        {
            var data = await _assessment.BindCust();
            return Ok(data);
        }
        [HttpPost("BindSubcat")]
        public async Task<IActionResult> BindSubcat(AssessmentEntity obj)
        {
            var data = await _assessment.BindSubcat(obj);
            return Ok(data);
        }
        [HttpPost("Binditem")]
        public async Task<IActionResult> Binditem(AssessmentEntity obj)
        {
            var data = await _assessment.Binditem(obj);
            return Ok(data);
        }
        [HttpPost("GetAllbyLastOrderno")]
        public async Task<IActionResult> GetAllbyLastOrderno(AssessmentEntity obj)
        {
            var data = await _assessment.GetAllbyLastOrderno();
            return Ok(data);
        }
        [HttpPost("InsertSalesSlave")]
        public async Task<IActionResult> InsertSalesSlave(AssessmentEntity obj)
        {
            var data = await _assessment.InsertSalesSlave(obj);
            return Ok(data);
        }
        [HttpPost("InsertSalesMaster")]
        public async Task<IActionResult> InsertSalesMaster(AssessmentEntity obj)
        {
            var data = await _assessment.InsertSalesMaster(obj);
            return Ok(data);
        }
    }
}
