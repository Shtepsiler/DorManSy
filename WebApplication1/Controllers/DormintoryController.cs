using Microsoft.AspNetCore.Mvc;
using DAL.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DormintoryController : ControllerBase
    {
        protected UnitOfWork unitOfWork;
        // GET: api/<DormintoryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return (IEnumerable<string>)unitOfWork._DormitoryRepository.GetAsync();
        }
/*
        // GET api/<DormintoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DormintoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DormintoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DormintoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
