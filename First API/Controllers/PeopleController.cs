using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace First_API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PeopleController : ControllerBase
    {
        [HttpGet("get-all-users")]
        public async Task<IActionResult> GetAllUsers()
        {
            List<string> people = new()
            {
                "Murad",
                "Senan",
                "Zabil",
                "Result"
            };
            return Ok(people);
        }

        [HttpPost("create-person")]
        public async Task<IActionResult> CreatePerson(Person person, [FromHeader] string token)
        {
            return Ok("New Person Added");
        }

        [HttpGet]
        public async Task<IActionResult> BadResponseResult()
        {
            return BadRequest();
        }

    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string FullName { get; set; }
    }

}