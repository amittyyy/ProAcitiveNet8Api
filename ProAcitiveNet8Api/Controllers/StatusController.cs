using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProAcitiveNet8Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        // GET: api/<StatusController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "This is Status Controller", "Part 1" };
        }

        // GET api/<StatusController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "This is get by id";
        }

        // POST api/<StatusController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StatusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StatusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
