using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Recruitment.Application.MCandidate;
using Recruitment.Data.DataContext;
using Recruitment.Data.Entities;
using Recruitment.WebApp.Service.CandidateService;

namespace Recruitment.WebApp.Controllers
{
    [Route("ung-vien")]
    [AllowAnonymous]
    public class CandidatesController : Controller
    {
        private readonly DataDbContext _context;
        private readonly ICandidateApiClient _candidateApiClient;
        private readonly IFileProvider fileProvider;
        [Obsolete]
        private IHostingEnvironment _hostingEnvironment;

        [Obsolete]
        public CandidatesController(DataDbContext context, ICandidateApiClient jobApiClient, IFileProvider fileProvider, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _candidateApiClient = jobApiClient;
            this.fileProvider = fileProvider;
            _hostingEnvironment = hostingEnvironment;
        }
        [Route("ung-tuyen/{jobId}")]
        [HttpGet]
        public IActionResult Create(Guid jobId, IFormFile Resume)
        {
            return View();
        }

        [Route("ung-tuyen/{jobId}")]
        [HttpPost]
        public async Task<IActionResult> Create(CandidateRequest request, Guid jobId, IFormFile Resume)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Resume == null || Resume.Length == 0)
                        return Content("file not selected");

                    var path = Path.Combine(
                                Directory.GetCurrentDirectory(), "wwwroot/resume",
                                Resume.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await Resume.CopyToAsync(stream);
                    }

                    request.Resume = Resume.FileName.ToString();
                    request.Id = new Guid();
                    request.JobId = jobId;
                    request.CreatedOn = DateTime.Now;
                    request.IsActive = true;

                    var response = await _candidateApiClient.Create(request);


                }
                return RedirectToAction("index", "home");
            }

            catch
            {
                return View();
            }
        }


    }
}
