using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip;
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


        [Route("downloadzip")]
        public FileResult DownloadZip(string[] filenames)
        {
            var webRoot = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot");
            var fileName = "resources" + ".zip";
            var tempoutput = webRoot + "/resume/" + fileName;

            using (ZipOutputStream zipOutputStream = new ZipOutputStream(System.IO.File.Create(tempoutput)))
            {
                zipOutputStream.SetLevel(9);

                byte[] buffer = new byte[1000000000];

                var fileList = new List<string>();

                foreach (var file in filenames)
                {
                    fileList.Add(webRoot + "/resume/" + file);
                }



                for (int i = 0; i < fileList.Count; i++)
                {
                    ZipEntry entry = new ZipEntry(Path.GetFileName(fileList[i]));
                    entry.DateTime = DateTime.Now;
                    entry.IsUnicodeText = true;
                    zipOutputStream.PutNextEntry(entry);

                    using FileStream fileStream = System.IO.File.OpenRead(fileList[i]);
                    int sourceBytes;
                    do
                    {
                        sourceBytes = fileStream.Read(buffer, 0, buffer.Length);
                        zipOutputStream.Write(buffer, 0, sourceBytes);
                    } while (sourceBytes > 0);
                }
                zipOutputStream.Finish();
                zipOutputStream.Flush();
                zipOutputStream.Close();
            }
            byte[] finalResult = System.IO.File.ReadAllBytes(tempoutput);
            if (System.IO.File.Exists(tempoutput))
            {
                System.IO.File.Delete(tempoutput);
            }

            if (finalResult == null || !finalResult.Any())
            {
                throw new Exception(String.Format("nothing found!"));
            }

            return File(finalResult, "application/zip", fileName);
        }
    }
}