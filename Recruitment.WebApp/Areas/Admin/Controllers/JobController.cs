using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;
using OfficeOpenXml;
using Recruitment.Application.MJob;
using Recruitment.Common.String;
using Recruitment.Data.DataContext;
using Recruitment.Data.Entities;
using Recruitment.WebApp.Service.JobService;

namespace Recruitment.WebApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("admin/jobs")]
	[Authorize(Roles = "Admin,Recruitment")]
	public class JobController : Controller
	{
		private readonly IJobApiClient _jobApiClient;

		private readonly DataDbContext _context;

		private readonly IWebHostEnvironment webHostEnvironment;

		public JobController(IJobApiClient jobApiClient, IWebHostEnvironment hostEnvironment, DataDbContext context)
		{
			_jobApiClient = jobApiClient;
			webHostEnvironment = hostEnvironment;
			_context = context;
		}

		[Route("index")]
		[Route("")]
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			ViewBag.CountListJob = _context.JobJobs.Count();
			var response = await _jobApiClient.GetAll();

			var model = JsonConvert.DeserializeObject<List<JobResponse>>(response);

			return View(model.OrderByDescending(p => p.CreatedOn));
		}

		[Route("detail/{id}")]
		[HttpGet]
		public async Task<IActionResult> Details(Guid? id)
		{
			var response = await _jobApiClient.Details(id);
			var model = JsonConvert.DeserializeObject<JobResponse>(response.ToString());

			return View(model);
		}

		[Route("create")]
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[Route("create")]
		[HttpPost]
		public async Task<IActionResult> Create(JobRequest request, IFormFile JobImage)
		{
			try
			{
				if(ModelState.IsValid)
				{
					// Thêm ảnh vào wwwroot
					var fileName = Path.GetFileName(JobImage.FileName);
					var myUniqueFileName = Convert.ToString(Guid.NewGuid());
					var fileExtension = Path.GetExtension(fileName);
					var newFileName = String.Concat(myUniqueFileName, fileExtension);

					var filepath =
			new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "client/assets/img")).Root + $@"\{newFileName}";

					using (FileStream fs = System.IO.File.Create(filepath))
					{
						JobImage.CopyTo(fs);
						fs.Flush();
					}

					var newImageName = newFileName;
					request.JobImage = newImageName.ToString();
					string year = DateTime.Now.ToString("yy");
					string month = DateTime.Now.ToString("MM");
					string seconds = DateTime.Now.ToString("ss");
					string timespan = DateTime.Now.ToString("yyyyMMddHHmmss");
					request.Slug = Helper.UpperToLower(Helper.ToUnsignString(request.Position)) + year + seconds;
					request.CreatedOn = DateTime.Now;
					request.IsActive = true;
					request.Id = new Guid();
					// TODO: Add insert logic here 
					var response = await _jobApiClient.Create(request);
				}
				

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		[Route("changeimage/{id}")]
		[HttpGet]
		public async Task<IActionResult> ChangeImage(Guid? id)
		{
			var request = await _jobApiClient.FindById(id);
			var model = JsonConvert.DeserializeObject<JobRequest>(request.ToString());

			return View(model);
		}

		[Route("changeimage/{id}")]
		[HttpPost]
		public async Task<IActionResult> ChangeImage(JobRequest request, IFormFile JobImage)
		{
			try
			{
				var fileName = Path.GetFileName(JobImage.FileName);
				var myUniqueFileName = Convert.ToString(Guid.NewGuid());
				var fileExtension = Path.GetExtension(fileName);
				var newFileName = String.Concat(myUniqueFileName, fileExtension);

				var filepath =
		new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "client/assets/img")).Root + $@"\{newFileName}";

				using (FileStream fs = System.IO.File.Create(filepath))
				{
					JobImage.CopyTo(fs);
					fs.Flush();
				}

				var newImageName = newFileName;
				request.JobImage = newImageName.ToString();
				request.UpdatedOn = DateTime.Now;
				// TODO: Add insert logic here 
				var response = await _jobApiClient.Update(request);

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		[Route("edit/{id}")]
		[HttpGet]
		public async Task<IActionResult> Update(Guid? id)
		{
			var request = await _jobApiClient.FindById(id);
			var model = JsonConvert.DeserializeObject<JobRequest>(request.ToString());


			return View(model);

		}
		[Route("edit/{id}")]
		[HttpPost]
		public async Task<IActionResult> Update(JobRequest request)
		{
			try
			{
				if(ModelState.IsValid)
				{
					//request.IsActive = true;
					request.UpdatedOn = DateTime.Now;
					// TODO: Add insert logic here 
					var response = await _jobApiClient.Update(request);
				}

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		[Route("delete/{id}")]
		[HttpGet]
		public async Task<IActionResult> Delete(Guid? id)
		{
			var req = await _jobApiClient.FindById(id);
			var model = JsonConvert.DeserializeObject<JobRequest>(req.ToString());

			await _jobApiClient.Delete(model);

			return RedirectToAction("Index");

		}

		[Route("delete/{id}")]
		[HttpPost]
		public async Task<IActionResult> Delete(JobRequest request)
		{
			try
			{
				// TODO: Add insert logic here 
				var response = await _jobApiClient.Delete(request);

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		//public IActionResult ExportToExcel()
		//{
		//	var doctors = from m in _context.JobJobs
		//				  select m;

		//	byte[] fileContents;
		//	ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
		//	ExcelPackage Ep = new ExcelPackage();
		//	ExcelWorksheet Sheet = Ep.Workbook.Worksheets.Add("ListJobs");
		//	Sheet.Cells["A1"].Value = "Name";
		//	Sheet.Cells["B1"].Value = "Email";
		//	Sheet.Cells["C1"].Value = "Password";
		//	Sheet.Cells["D1"].Value = "Phone";
		//	Sheet.Cells["E1"].Value = "Gender";
		//	Sheet.Cells["F1"].Value = "Specialist";
		//	Sheet.Cells["G1"].Value = "CreatedOn";
		//	Sheet.Cells["H1"].Value = "Status";

		//	int row = 2;
		//	foreach (var item in doctors)
		//	{
		//		Sheet.Cells[string.Format("A{0}", row)].Value = item.Name;
		//		Sheet.Cells[string.Format("B{0}", row)].Value = item.Email;
		//		Sheet.Cells[string.Format("C{0}", row)].Value = item.Password;
		//		Sheet.Cells[string.Format("D{0}", row)].Value = item.Phone;
		//		Sheet.Cells[string.Format("E{0}", row)].Value = item.Gender;
		//		Sheet.Cells[string.Format("F{0}", row)].Value = item.Specialist;
		//		Sheet.Cells[string.Format("G{0}", row)].Value = item.CreatedOn;
		//		Sheet.Cells[string.Format("H{0}", row)].Value = item.Status;
		//		row++;
		//	}


		//	Sheet.Cells["A:AZ"].AutoFitColumns();
		//	Response.Clear();
		//	Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
		//	fileContents = Ep.GetAsByteArray();

		//	if (fileContents == null || fileContents.Length == 0)
		//	{
		//		return NotFound();
		//	}

		//	return File(
		//		fileContents: fileContents,
		//		contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
		//		fileDownloadName: "List-Doctors.xlsx"
		//	);
		//}

		[HttpPost]
		[Route("import")]
		public IActionResult ImportUpload(IFormFile reportfile)
		{
			string folderName = "Upload";
			string webRootPath = webHostEnvironment.WebRootPath;
			string newPath = Path.Combine(webRootPath, folderName);
			// Delete Files from Directory
			System.IO.DirectoryInfo di = new DirectoryInfo(newPath);
			foreach (FileInfo filesDelete in di.GetFiles())
			{
				filesDelete.Delete();
			}// End Deleting files form directories

			if (!Directory.Exists(newPath))// Crate New Directory if not exist as per the path
			{
				Directory.CreateDirectory(newPath);
			}
			var fiName = Guid.NewGuid().ToString() + Path.GetExtension(reportfile.FileName);
			using (var fileStream = new FileStream(Path.Combine(newPath, fiName), FileMode.Create))
			{
				reportfile.CopyTo(fileStream);
			}
			// Get uploaded file path with root
			string rootFolder = webHostEnvironment.WebRootPath;
			string fileName = @"Upload/" + fiName;
			FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));

			using (ExcelPackage package = new ExcelPackage(file))
			{
				ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
				ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
				int totalRows = workSheet.Dimension.Rows;
				List<Job> reportList = new List<Job>();
				for (int i = 2; i <= totalRows; i++)
				{
					try
					{
						string Position = workSheet?.Cells[i, 1]?.Value?.ToString();
						string ApplicationEmail = workSheet?.Cells[i, 2]?.Value?.ToString();
						string JobDetail = workSheet?.Cells[i, 3]?.Value?.ToString();
						string Amount = workSheet?.Cells[i, 4]?.Value?.ToString();
						string Experience = workSheet?.Cells[i, 5]?.Value?.ToString();
						string SalaryMin = workSheet?.Cells[i, 6]?.Value?.ToString();
						string SalaryMax = workSheet?.Cells[i, 7]?.Value?.ToString();
						string SalaryUnit = workSheet?.Cells[i, 8]?.Value?.ToString();
						string WorkTime = workSheet?.Cells[i, 9]?.Value?.ToString();
						string Address = workSheet?.Cells[i, 10]?.Value?.ToString();
						string DealineForSubmission = workSheet?.Cells[i, 11]?.Value?.ToString();
						workSheet.Cells[i, 11].Style.Numberformat.Format = "dd-MM-yyyy";
						string Image = workSheet?.Cells[i, 12]?.Value?.ToString();
						reportList.Add(new Job
						{
							Position = Position,
							ApplicationEmail = ApplicationEmail,
							JobDetail = JobDetail,
							Amount = int.Parse(Amount),
							Experience = Experience,
							SalaryMin = int.Parse(SalaryMin),
							SalaryMax = int.Parse(SalaryMax),
							SalaryUnit = SalaryUnit,
							WorkTime = int.Parse(WorkTime),
							Address = Address,
							CreatedOn = DateTime.Now,
							DealineForSubmission = DateTime.Parse(DealineForSubmission),
							IsActive = true,
							Slug = Helper.UpperToLower(Helper.ToUnsignString(Position)),
							JobImage = Image
						}); 
					}
					catch (Exception Ex)
					{
						// Exception
					}
				}
				_context.JobJobs.AddRange(reportList);
				_context.SaveChanges();

				return RedirectToAction("index");
			}
		}

		[HttpGet]
		[Route("set-featured/{jobId}")]
		public async Task<IActionResult> SetFeatured(Guid jobId)
		{
			var job = await _context.JobJobs.FindAsync(jobId);

			if(job.IsActive == true)
			{
				job.IsActive = false;
			} else
			{
				job.IsActive = true;
			}
			
			await _context.SaveChangesAsync();

			return RedirectToAction(nameof(Index));
		}

	}
}