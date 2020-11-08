using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruitment.Application.MFeedback;

namespace Recruitment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        // GET: 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _feedbackService.GetAll());
        }

        // GET: 
        [HttpPost("Create")]
        public async Task<IActionResult> Post([FromBody]FeedbackRequest request)
        {
            return Ok(await _feedbackService.Create(request));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody]FeedbackRequest request)
        {
            return Ok(await _feedbackService.Update(request));
        }


        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody]FeedbackRequest request)
        {
            return Ok(await _feedbackService.Delete(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(Guid? id)
        {
            return Ok(await _feedbackService.Details(id));
        }

        [HttpGet("FindById/{id}")]
        public async Task<IActionResult> FindById(Guid? id)
        {
            return Ok(await _feedbackService.FindById(id));
        }
    }
}