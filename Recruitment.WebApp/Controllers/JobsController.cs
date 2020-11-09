using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Recruitment.Application.MFeedback;
using Recruitment.Application.MJob;
using Recruitment.Data.DataContext;
using Recruitment.Data.Entities;
using Recruitment.WebApp.Service.FeedbackService;
using Recruitment.WebApp.Service.JobService;

namespace Recruitment.WebApp.Controllers
{
    [Route("cong-viec")]
    [AllowAnonymous]
    public class JobsController : Controller
    {
        private readonly DataDbContext _context;
        private readonly IJobApiClient _jobApiClient;
        private readonly IFeedbackApiClient _feedbackApiClient;


        public JobsController(DataDbContext context, IJobApiClient jobApiClient, IFeedbackApiClient feedbackApiClient)
        {
            _jobApiClient = jobApiClient;
            _feedbackApiClient = feedbackApiClient;
            _context = context;
        }

        [Route("index")]
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Index(string searchString)
        {
            var response = await _jobApiClient.GetAll();

            var model = JsonConvert.DeserializeObject<List<JobResponse>>(response);

            // Thêm chức năng tìm kiếm ngoài trang chủ
            var jobs = from m in _context.JobJobs
                          select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                jobs = jobs.Where(s => s.Position.Contains(searchString));
            }

            return View(model.OrderByDescending(p => p.CreatedOn));
        }

        [Route("~/chi-tiet/{slug}")]
        public async Task<IActionResult> Details(string slug)
        {
            if (slug == null)
            {
                return NotFound();
            }

            var job = await _context.JobJobs
                .FirstOrDefaultAsync(m => m.Slug == slug);

            ViewBag.JobId = job.Id;
            ViewBag.JobSlug = job.Slug;

            var comments = _context.Feedbacks.Where(d => d.JobId.Equals(job.Id)).ToList();
            ViewBag.Comments = comments;

            var ratings = _context.Feedbacks.Where(d => d.JobId.Equals(job.Id)).ToList();
            if (ratings.Count() > 0)
            {
                var ratingSum = ratings.Sum(d => d.Rating);
                ViewBag.RatingSum = ratingSum;
                var ratingCount = ratings.Count();
                ViewBag.RatingCount = ratingCount;
            }
            else
            {
                ViewBag.RatingSum = 0;
                ViewBag.RatingCount = 0;
            }

            ViewBag.RelativeJob = RelativeJobs(3, job.Id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        [Route("detail/{id}")]
		[HttpGet]
		public async Task<IActionResult> Details(Guid? id)
		{
			var response = await _jobApiClient.Details(id);
			var model = JsonConvert.DeserializeObject<JobResponse>(response.ToString());

			return View(model);
		}

        public List<Job> RelativeJobs(int top, Guid id)
        {
            return _context.JobJobs.Take(top).Where(j => j.Id != id).ToList();

        }

    }
}
