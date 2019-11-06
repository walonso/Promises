using Microsoft.AspNetCore.Mvc;
using Promesas.Model;

namespace Promesas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public ActionResult<bool> Save()
        {
            System.Threading.Thread.Sleep(5000);
            return true;
        }

        [HttpPut]
        public string SaveImage()
        {
            System.Threading.Thread.Sleep(5000);
            return "saved image";
        }

        [HttpGet]
        public ActionResult<Person> Get(int id)
        {
            System.Threading.Thread.Sleep(5000);
            return new Person
            {
                Name = "name1",
                LastName = "lastname 1"
            };
        }
    }
}