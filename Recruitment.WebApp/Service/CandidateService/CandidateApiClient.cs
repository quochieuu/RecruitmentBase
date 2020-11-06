using Newtonsoft.Json;
using Recruitment.Application.MCandidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.WebApp.Service.CandidateService
{
    public class CandidateApiClient : ICandidateApiClient
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public CandidateApiClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<string> Create(CandidateRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.PostAsync("api/Candidate/Create", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Update(CandidateRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.PostAsync("api/Candidate/Update", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Delete(CandidateRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.PostAsync("api/Candidate/Delete", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Details(Guid? id)
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.GetAsync("api/Candidate/" + id);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> FindById(Guid? id)
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.GetAsync("api/Candidate/FindById/" + id);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> GetAll()
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.GetAsync("api/Candidate");

			return await response.Content.ReadAsStringAsync();
		}
	}
}
