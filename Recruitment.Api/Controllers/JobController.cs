using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruitment.Application.MJob;

namespace Recruitment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        // GET: 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _jobService.GetAll());
        }

        // GET: 
        [HttpPost("Create")]
        public async Task<IActionResult> Post([FromBody]JobRequest request)
        {
            return Ok(await _jobService.Create(request));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody]JobRequest request)
        {
            return Ok(await _jobService.Update(request));
        }


        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody]JobRequest request)
        {
            return Ok(await _jobService.Delete(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(Guid? id)
        {
            return Ok(await _jobService.Details(id));
        }

        [HttpGet("FindById/{id}")]
        public async Task<IActionResult> FindById(Guid? id)
        {
            return Ok(await _jobService.FindById(id));
        }
    }
}