using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Nodes;
using toDoList.UI.Models.toDoList;

namespace toDoList.UI.Controllers
{

    public class adminToDoListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public adminToDoListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var ResponseMessage = await client.GetAsync("https://localhost:7208/api/AdminToDoList");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var datas = await ResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<toDoListViewModel>>(datas);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult addToDoList()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> addToDoList(addToDoListViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var ResponseMessage = await client.PostAsync("https://localhost:7208/api/AdminToDoList", content);
            if (ResponseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> ToDoListDelete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7208/api/AdminToDoList/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> UpdateToDoList(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7208/api/AdminToDoList/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<updateToDoListViewModel>(datas);
                return View(values);
            }
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> UpdateToDoList(updateToDoListViewModel model)
        {
            var client=_httpClientFactory.CreateClient();
            var data=JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data,Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7208/api/AdminToDoList/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
