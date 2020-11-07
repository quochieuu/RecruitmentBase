using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Recruitment.WebApp.Areas.Admin.ViewModel;

namespace Recruitment.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/home")]
    [Route("admin")]
    [Authorize(Roles = "Admin,Recruitment")]
    public class HomeController : Controller
    {
        private readonly IFileProvider fileProvider;
        [Obsolete]
        private IHostingEnvironment _hostingEnvironment;

        [Obsolete]
        public HomeController(IFileProvider fileProvider, IHostingEnvironment hostingEnvironment)
        {
            this.fileProvider = fileProvider;
            _hostingEnvironment = hostingEnvironment;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("resume")]
        public IActionResult Files()
        {
            var model = new FilesViewModel();
            foreach (var item in this.fileProvider.GetDirectoryContents("resume"))
            {
                model.Files.Add(
                    new FileDetails { Name = item.Name, Path = item.PhysicalPath });
            }
            return View(model);
        }
    }
}