using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Recruitment.Application.MCandidate;
using Recruitment.WebApp.Service.CandidateService;

namespace Recruitment.WebApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("admin/candidates")]
	[Authorize(Roles = "Admin")]
	public class CandidateController : Controller
    {
		private readonly ICandidateApiClient _candidateApiClient;

		public CandidateController(ICandidateApiClient jobApiClient)
		{
			_candidateApiClient = jobApiClient;
		}

		[Route("index")]
		[Route("")]
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var response = await _candidateApiClient.GetAll();

			var model = JsonConvert.DeserializeObject<List<CandidateResponse>>(response);

			return View(model);
		}

		[Route("detail/{id}")]
		[HttpGet]
		public async Task<IActionResult> Details(Guid? id)
		{
			var response = await _candidateApiClient.Details(id);
			var model = JsonConvert.DeserializeObject<CandidateResponse>(response.ToString());

			return View(model);
		}

		[Route("create")]
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();
		}

		[Route("create")]
		[HttpPost]
		public async Task<IActionResult> Create(CandidateRequest request)
		{
			try
			{
				if(ModelState.IsValid)
				{
					// TODO: Add insert logic here 
					var response = await _candidateApiClient.Create(request);
				}

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
			var request = await _candidateApiClient.FindById(id);
			var model = JsonConvert.DeserializeObject<CandidateRequest>(request.ToString());


			return View(model);

		}

		[Route("edit/{id}")]
		[HttpPost]
		public async Task<IActionResult> Update(CandidateRequest request)
		{
			try
			{
				if(ModelState.IsValid)
				{
					// TODO: Add insert logic here 
					var response = await _candidateApiClient.Update(request);
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
			var req = await _candidateApiClient.FindById(id);
			var model = JsonConvert.DeserializeObject<CandidateRequest>(req.ToString());

			await _candidateApiClient.Delete(model);

			return RedirectToAction("Index");

		}

		[Route("delete/{id}")]
		[HttpPost]
		public async Task<IActionResult> Delete(CandidateRequest request)
		{
			try
			{
				// TODO: Add insert logic here 
				var response = await _candidateApiClient.Delete(request);

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		[Route("download/{filename}")]
		public async Task<IActionResult> Download(string filename)
		{
			if (filename == null)
				return Content("filename not present");

			var path = Path.Combine(
						   Directory.GetCurrentDirectory(),
						   "wwwroot/resume", filename);

			var memory = new MemoryStream();
			using (var stream = new FileStream(path, FileMode.Open))
			{
				await stream.CopyToAsync(memory);
			}
			memory.Position = 0;
			return File(memory, GetContentType(path), Path.GetFileName(path));
		}

		private string GetContentType(string path)
		{
			var types = GetMimeTypes();
			var ext = Path.GetExtension(path).ToLowerInvariant();
			return types[ext];
		}

		private Dictionary<string, string> GetMimeTypes()
		{
			return new Dictionary<string, string>
			{
				{".txt", "text/plain"},
				{".pdf", "application/pdf"},
				{".doc", "application/vnd.ms-word"},
				{".docx", "application/vnd.ms-word"},
				{".xls", "application/vnd.ms-excel"},
				{".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
				{".png", "image/png"},
				{".jpg", "image/jpeg"},
				{".jpeg", "image/jpeg"},
				{".gif", "image/gif"},
				{".csv", "text/csv"}
			};
		}
	}
}