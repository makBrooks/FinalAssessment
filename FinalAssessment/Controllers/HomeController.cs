using FinalAssessment.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FinalAssessment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        Uri baseAdd = new Uri("https://localhost:7016/api/");

        HttpClient _client;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
            _client = new HttpClient();
            _client.BaseAddress = baseAdd;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> InsertSalesMaster(AssessmentEntity obj)
        {
            try
            {
                string data = JsonConvert.SerializeObject(obj);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync(_client.BaseAddress + "AssessmentAPI/InsertSalesMaster/", content);
                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    if (res != null)
                    {
                        return Json(res);
                    }
                    else
                    {
                        return Json(null);
                    }
                }
                else
                {
                    return Json(null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public async Task<IActionResult> InsertSalesSlave(AssessmentEntity obj)
        {
            try
            {
                string data = JsonConvert.SerializeObject(obj);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync(_client.BaseAddress + "AssessmentAPI/InsertSalesSlave/", content);
                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    if (res != null)
                    {
                        return Json(res);
                    }
                    else
                    {
                        return Json(null);
                    }
                }
                else
                {
                    return Json(null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public async Task<IActionResult> BindCust()
        {
            try
            {
                AssessmentEntity obj = new AssessmentEntity();
                string data = JsonConvert.SerializeObject(obj);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync(_client.BaseAddress + "AssessmentAPI/BindCust/", content);
                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    if (res != null)
                    {
                        return Json(res);
                    }
                    else
                    {
                        return Json(null);
                    }
                }
                else
                {
                    return Json(null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public async Task<IActionResult> BindSubcat(AssessmentEntity obj)
        {
            try
            {
                string data = JsonConvert.SerializeObject(obj);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync(_client.BaseAddress + "AssessmentAPI/BindSubcat/", content);
                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    if (res != null)
                    {
                        return Json(res);
                    }
                    else
                    {
                        return Json(null);
                    }
                }
                else
                {
                    return Json(null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IActionResult> Binditem(AssessmentEntity obj)
        {
            try
            {
                string data = JsonConvert.SerializeObject(obj);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync(_client.BaseAddress + "AssessmentAPI/Binditem/", content);
                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    if (res != null)
                    {
                        return Json(res);
                    }
                    else
                    {
                        return Json(null);
                    }
                }
                else
                {
                    return Json(null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public async Task<IActionResult> GetAllbyLastOrderno()
        {
            try
            {
                AssessmentEntity obj = new AssessmentEntity();
                string data = JsonConvert.SerializeObject(obj);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync(_client.BaseAddress + "AssessmentAPI/GetAllbyLastOrderno/", content);
                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    if (res != null)
                    {
                        return Json(res);
                    }
                    else
                    {
                        return Json(null);
                    }
                }
                else
                {
                    return Json(null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult AssessmentReport()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> GetDetailsByID(AssessmentEntity obj)
        //{
        //    try
        //    {
        //        string data = JsonConvert.SerializeObject(obj);
        //        StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
        //        HttpResponseMessage response;
        //        if (obj.BatchId!= "0")
        //        {
        //            response = await _client.PostAsync(_client.BaseAddress + "AssessmentAPI/GetDetailsByID/", content);
        //        }
        //        else
        //        {
        //            response = await _client.PostAsync(_client.BaseAddress + "AssessmentAPI/GetAll/", content);
        //        }
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var res = await response.Content.ReadAsStringAsync();
        //            if (res != null)
        //            {
        //                return Json(res);
        //            }
        //            else
        //            {
        //                return Json(null);
        //            }
        //        }
        //        else
        //        {
        //            return Json(null);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        public class Entity1
        {
            public string? catid { get; set; }
            public string? catname { get; set; }
        }


        public IActionResult getCat()
        {
            
            List<Entity1> lst = new List<Entity1>();
            Entity1 obj = new Entity1();
            obj.catid = "1";
            obj.catname = "Eloctronics";
            lst.Add(obj);
            Entity1 obj1 = new Entity1();
            obj1.catid = "2";
            obj1.catname = "Wood";
            lst.Add(obj1);
            return Json(lst);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}