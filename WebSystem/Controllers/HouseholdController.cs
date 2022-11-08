using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebSystem.Helper;
using WebSystem.Models;

namespace WebSystem.Controllers
{
    public class HouseholdController : Controller
    {
        HelperAPI _api = new HelperAPI();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetList()
        {
            List<Household> households = new List<Household>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/household");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                households = JsonConvert.DeserializeObject<List<Household>>(result);
            }
            return Json(households);
        }

        public IActionResult AddHousehold()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult AddHousehold(int id)
        //{
        //    //_oHousehold = new List<Household>();
        //    HttpClient client = _api.Initial();
        //    using (var httpClient = new HttpClient())
        //    {
        //        string jsonString = JsonConvert.SerializeObject(id, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
        //        StringContent content = new StringContent(jsonString);
        //        content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

        //        using var res = client.PostAsync(string.Format("api/household/" + id), content);
        //        return View();
        //    }
        //}
        
        [HttpPost]
        public async Task<IActionResult> AddHousehold(Household household)
        {
            HttpClient client = _api.Initial();
            using (var httpClient = new HttpClient())
            {
                string jsonString = JsonConvert.SerializeObject(household, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                StringContent content = new StringContent(jsonString);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                using var res = await client.PostAsync(string.Format("api/household", household), content);                
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            //HttpResponseMessage res = GlobalVariables.WebApiClient.DeleteAsync("Employee/" + id.ToString()).Result;
            //HttpResponseMessage res = Helper.HelperAPI.WebApiClient.DeleteAsync("household/" + id.ToString()).Result;
            //return RedirectToAction("Index");

            HttpClient Client = _api.Initial();
            using (var httpClient = new HttpClient())
            {
                string jsonString = JsonConvert.SerializeObject(id, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                StringContent content = new StringContent(jsonString);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                using var res = await Client.DeleteAsync(string.Format("api/household/{0}", id));
                string apiResponse = await res.Content.ReadAsStringAsync();
            }
            return RedirectToAction("Index");
        }

    }
}
