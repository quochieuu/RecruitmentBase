using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruitment.Application.MCandidate;

namespace Recruitment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService _candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        // GET: 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _candidateService.GetAll());
        }

        // GET: 
        [HttpPost("Create")]
        public async Task<IActionResult> Post([FromBody]CandidateRequest request)
        {
            return Ok(await _candidateService.Create(request));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody]CandidateRequest request)
        {
            return Ok(await _candidateService.Update(request));
        }


        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody]CandidateRequest request)
        {
            return Ok(await _candidateService.Delete(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(Guid? id)
        {
            return Ok(await _candidateService.Details(id));
        }

        [HttpGet("FindById/{id}")]
        public async Task<IActionResult> FindById(Guid? id)
        {
            return Ok(await _candidateService.FindById(id));
        }
    }
}