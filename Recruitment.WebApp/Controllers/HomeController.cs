using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Recruitment.Data.DataContext;
using Recruitment.WebApp.Models;

namespace Recruitment.WebApp.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataDbContext _context;

        public HomeController(DataDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index(string searchString)
        {
            // Thêm chức năng tìm kiếm ngoài trang chủ
            if (!String.IsNullOrEmpty(searchString))
            {
                ViewBag.ListJob = _context.JobJobs.Where(s => s.Position.Contains(searchString) && s.IsActive == true).OrderByDescending(p => p.CreatedOn).ToList();
                ViewBag.CountListJob = _context.JobJobs.Where(j => j.Position.Contains(searchString) && j.IsActive == true).Count();
            } else
            {
                ViewBag.ListJob = _context.JobJobs.Where(j => j.IsActive == true).OrderByDescending(p => p.CreatedOn).ToList();
                ViewBag.CountListJob = _context.JobJobs.Where(j => j.IsActive == true).Count();
            }
            
            
            return View();
        }

        // GET: Jobs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.JobJobs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
