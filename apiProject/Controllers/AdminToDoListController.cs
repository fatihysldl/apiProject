using apiProject.BusinessLayer.concrete;
using apiProject.DataAccessLayer.concrete;
using apiProject.DataAccessLayer.EntityFramework;
using apiProject.EntityLayer.context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminToDoListController : ControllerBase
    {
        private readonly IToDoListService _service;

        public AdminToDoListController(IToDoListService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult ToDoList()
        {
            var values=_service.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddToDoList(toDoList p)
        {
            _service.insert(p);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult deleteToDoList(int id)
        {
            var values = _service.getById(id);
            _service.delete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult updateToDoList(toDoList p)
        {
            _service.update(p);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetToDoList(int id)
        {
            var values=_service.getById(id);
            return Ok(values);
        }
    }
}
