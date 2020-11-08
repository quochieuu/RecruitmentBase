using Newtonsoft.Json;
using Recruitment.Application.MFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.WebApp.Service.FeedbackService
{
    public class FeedbackApiClient : IFeedbackApiClient
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public FeedbackApiClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<string> Create(FeedbackRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.PostAsync("api/Feedback/Create", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Update(FeedbackRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.PostAsync("api/Feedback/Update", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Delete(FeedbackRequest request)
		{
			var json = JsonConvert.SerializeObject(request);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.PostAsync("api/Feedback/Delete", httpContent);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> Details(Guid? id)
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.GetAsync("api/Feedback/" + id);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> FindById(Guid? id)
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.GetAsync("api/Feedback/FindById/" + id);

			return await response.Content.ReadAsStringAsync();
		}

		public async Task<string> GetAll()
		{
			var json = JsonConvert.SerializeObject(null);
			var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri("https://localhost:5002");
			var response = await client.GetAsync("api/Feedback");

			return await response.Content.ReadAsStringAsync();
		}
	}
}
