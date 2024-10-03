using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using AspMvc.Models;
namespace AspMvc.Controllers
{
    public class MyDataController : Controller
    {
        private readonly HttpClient _httpClient;
        public MyDataController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        // This method calls the API and passes data to the view
        public async Task<IActionResult> Index()
        {
            // Call the API endpoint (replace URL with your actual API endpoint)
            var response = await _httpClient.GetAsync("https://localhost:44351/api/mydata");
            response.EnsureSuccessStatusCode();
            // Deserialize the JSON response into a list of objects
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<MyDataModel>>(jsonResponse);
            // Pass the data to the view
            return View(data);
        }
    }
}





