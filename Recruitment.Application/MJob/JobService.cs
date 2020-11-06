using Microsoft.EntityFrameworkCore;
using Recruitment.Data.DataContext;
using Recruitment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Application.MJob
{
    public class JobService : IJobService
    {
		private readonly DataDbContext _context;

		public JobService(DataDbContext context)
		{
			_context = context;
		}

		public async Task<int> Create(JobRequest jobRequest)
		{
			var job = new Job()
			{
				Position = jobRequest.Position,
				Slug = jobRequest.Slug,
				ApplicationEmail = jobRequest.ApplicationEmail,
				JobImage = jobRequest.JobImage,
				JobDetail = jobRequest.JobDetail,
				Amount = jobRequest.Amount,
				Experience = jobRequest.Experience,
				SalaryMin = jobRequest.SalaryMin,
				SalaryMax = jobRequest.SalaryMax,
				SalaryUnit = jobRequest.SalaryUnit,
				WorkTime = jobRequest.WorkTime,
				Address = jobRequest.Address,
				DealineForSubmission = jobRequest.DealineForSubmission,
				CreatedOn = jobRequest.CreatedOn,
				UpdatedOn = jobRequest.UpdatedOn,
				IsActive = jobRequest.IsActive
			};
			_context.JobJobs.Add(job);

			return await _context.SaveChangesAsync();
		}


		public Task<int> Delete(JobRequest jobRequest)
		{
			var job = new Job()
			{
				Id = jobRequest.Id
			};
			_context.JobJobs.Remove(job);

			return _context.SaveChangesAsync();
		}

		public Task<int> Update(JobRequest jobRequest)
		{
			var job = new Job()
			{
				Id = jobRequest.Id,
				Position = jobRequest.Position,
				Slug = jobRequest.Slug,
				ApplicationEmail = jobRequest.ApplicationEmail,
				JobImage = jobRequest.JobImage,
				JobDetail = jobRequest.JobDetail,
				Amount = jobRequest.Amount,
				Experience = jobRequest.Experience,
				SalaryMin = jobRequest.SalaryMin,
				SalaryMax = jobRequest.SalaryMax,
				SalaryUnit = jobRequest.SalaryUnit,
				WorkTime = jobRequest.WorkTime,
				Address = jobRequest.Address,
				DealineForSubmission = jobRequest.DealineForSubmission,
				CreatedOn = jobRequest.CreatedOn,
				UpdatedOn = jobRequest.UpdatedOn,
				IsActive = jobRequest.IsActive
			};
			_context.JobJobs.Update(job);

			return _context.SaveChangesAsync();
		}


		public async Task<List<JobResponse>> GetAll()
		{
			return await _context.JobJobs
				.Select(x => new JobResponse()
				{
					Id = x.Id,
					Position = x.Position,
					Slug = x.Slug,
					ApplicationEmail = x.ApplicationEmail,
					JobImage = x.JobImage,
					JobDetail = x.JobDetail,
					Amount = x.Amount,
					Experience = x.Experience,
					SalaryMin = x.SalaryMin,
					SalaryMax = x.SalaryMax,
					SalaryUnit = x.SalaryUnit,
					WorkTime = x.WorkTime,
					Address = x.Address,
					DealineForSubmission = x.DealineForSubmission,
					CreatedOn = x.CreatedOn,
					UpdatedOn = x.UpdatedOn,
					IsActive = x.IsActive
				}).ToListAsync();
		}

		public async Task<Job> Details(Guid? id)
		{
			return await _context.JobJobs.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<Job> FindById(Guid? id)
		{
			return await _context.JobJobs.FindAsync(id);
		}

	}
}
