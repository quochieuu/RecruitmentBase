using Newtonsoft.Json;
using Recruitment.Application.MJob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.WebApp.Service.JobService
{
    public class JobApiClient : IJobApiClient
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public JobApiClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<string> Create(JobRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.PostAsync("api/Job/Create", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Update(JobRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.PostAsync("api/Job/Update", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Delete(JobRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.PostAsync("api/Job/Delete", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Details(Guid? id)
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.GetAsync("api/Job/" + id);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> FindById(Guid? id)
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.GetAsync("api/Job/FindById/" + id);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> GetAll()
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.GetAsync("api/Job");

			return await response.Content.ReadAsStringAsync();
		}
	}
}
