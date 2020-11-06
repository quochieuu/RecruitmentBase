using System;
using System.Collections.Generic;
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
				// TODO: Add insert logic here 
				var response = await _candidateApiClient.Create(request);

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
				// TODO: Add insert logic here 
				var response = await _candidateApiClient.Update(request);

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
	}
}