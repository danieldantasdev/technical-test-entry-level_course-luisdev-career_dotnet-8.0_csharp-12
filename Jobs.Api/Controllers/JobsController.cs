using Jobs.Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jobs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        // GET api/jobs
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // GET api/jobs/123
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //return NotFound();
            return Ok();
        }

        // POST api/jobs
        [HttpPost]
        public IActionResult Post(Job job)
        {
            return CreatedAtAction(nameof(GetById), new { id = job.Id }, job);
        }

        // PUT api/jobs/123
        [HttpPut("{id}")]
        public IActionResult Put(int id, Job job)
        {
            return NoContent();
        }

        // DELETE api/jobs/123
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
