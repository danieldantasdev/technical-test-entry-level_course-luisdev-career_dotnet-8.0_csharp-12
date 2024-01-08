using Jobs.DatabaseSqlServer.Api.Entities;
using Jobs.Api.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jobs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController(JobsDbContext jobsDbContext) : ControllerBase
    {
        private readonly JobsDbContext _jobsDbContext = jobsDbContext;

        // GET api/jobs
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Job> jobs = [.. _jobsDbContext.Jobs.AsNoTracking()];
            //var jobs = _jobsDbContext.Jobs.AsNoTracking().ToList();
            return Ok(jobs);
        }

        // GET api/jobs/123
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Job? job = _jobsDbContext
                .Jobs
                .AsNoTracking()
                .SingleOrDefault(j => j.Id == id);

            if (job is null)
            {
                return NotFound();
            }

            return Ok(job);
        }

        // POST api/jobs
        [HttpPost]
        public IActionResult Post(Job jobInputModel)
        {
            _jobsDbContext.Jobs.Add(jobInputModel);
            _jobsDbContext.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = jobInputModel.Id }, jobInputModel);
        }

        // PUT api/jobs/123
        [HttpPut("{id}")]
        public IActionResult Put(int id, Job jobInputModel)
        {
            Job? job = _jobsDbContext.Jobs.SingleOrDefault(j => j.Id == id);

            if (job is null)
            {
                return NotFound();
            }

            job.Update(jobInputModel);
            _jobsDbContext.Update(job);
            _jobsDbContext.SaveChanges();

            return NoContent();
        }

        // DELETE api/jobs/123
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Job? job = _jobsDbContext.Jobs.SingleOrDefault(j => j.Id == id);

            if (job is null)
            {
                return NotFound();
            }

            _jobsDbContext.Jobs.Remove(job);
            _jobsDbContext.SaveChanges();

            return NoContent();
        }
    }
}
