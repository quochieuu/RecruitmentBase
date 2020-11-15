using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Recruitment.Application.MFeedback;
using Recruitment.WebApp.Service.FeedbackService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.WebApp.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("admin/feedbacks")]
    [Authorize(Roles = "Admin,Recruitment")]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackApiClient _feedbackApiClient;

        public FeedbackController(IFeedbackApiClient feedbackApiClient)
        {
            _feedbackApiClient = feedbackApiClient;
        }

        [Route("index")]
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _feedbackApiClient.GetAll();

            var model = JsonConvert.DeserializeObject<List<FeedbackResponse>>(response);

            return View(model);
        }

        [Route("delete/{id}")]
        [HttpGet]
        public async Task<IActionResult> Delete(Guid? id)
        {
            var req = await _feedbackApiClient.FindById(id);
            var model = JsonConvert.DeserializeObject<FeedbackRequest>(req.ToString());

            await _feedbackApiClient.Delete(model);

            return RedirectToAction("Index");

        }
    }
}
