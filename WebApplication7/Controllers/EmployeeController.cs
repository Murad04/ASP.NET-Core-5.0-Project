using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.Controllers
{
    public class EmployeeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpclient = new HttpClient();
            var responseMessage = await httpclient.GetAsync("http://localhost:60819/api/Default");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
            return View(values);
        }
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Class1 p)
        {
            var httpclient = new HttpClient();
            var jsonEmployee = JsonConvert.SerializeObject(p);
            StringContent content = new(jsonEmployee, Encoding.UTF8, "application/json");
            var response = await httpclient.PostAsync("http://localhost:60819/api/Default", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }
        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var httpclient = new HttpClient();
            var response = await httpclient.GetAsync("http://localhost:60819/api/Default/" + id);
            if (response.IsSuccessStatusCode)
            {
                var jsonEmployee = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Class1>(jsonEmployee);
                return View(values);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditEmployee(Class1 p)
        {
            var httpclient = new HttpClient();
            var jsonEmployee = JsonConvert.SerializeObject(p);
            var content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");
            var response = await httpclient.PutAsync("http://localhost:60819/api/Default", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var httpclient = new HttpClient();
            var responsem = await httpclient.DeleteAsync("http://localhost:60819/api/Default/" + id);
            if (responsem.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
    public class Class1
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
