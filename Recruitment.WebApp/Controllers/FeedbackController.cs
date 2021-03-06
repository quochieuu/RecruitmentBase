﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recruitment.Application.MFeedback;
using Recruitment.Data.DataContext;
using Recruitment.WebApp.Service.FeedbackService;

namespace Recruitment.WebApp.Controllers
{
    [Route("feedback")]
    public class FeedbackController : Controller
    {
        private readonly DataDbContext _context;
        private readonly IFeedbackApiClient _feedbackApiClient;


        public FeedbackController(DataDbContext context, IFeedbackApiClient feedbackApiClient)
        {
            _feedbackApiClient = feedbackApiClient;
            _context = context;
        }

        [Route("feed")]
        [HttpGet]
        public IActionResult AddFeedback()
        {
            return View();
        }


        [Route("feed")]
        [HttpPost]
        public async Task<IActionResult> AddFeedback(FeedbackRequest request, string slug)
        {
            
            try
            {
                var jod = _context.JobJobs.FirstOrDefault(j => j.Slug == slug);
                var jodId = jod.Id;

                if (ModelState.IsValid)
                {
                    
                    request.Id = new Guid();
                    request.CommentOn = DateTime.Now;
                    var response = await _feedbackApiClient.Create(request);


                }
                return Redirect("~/chi-tiet/" + slug);
            }

            catch
            {
                return View();
            }
        }
    }
}