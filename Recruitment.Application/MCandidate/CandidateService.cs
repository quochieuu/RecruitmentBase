using Microsoft.EntityFrameworkCore;
using Recruitment.Data.DataContext;
using Recruitment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Application.MCandidate
{
    public class CandidateService : ICandidateService
    {
		private readonly DataDbContext _context;

		public CandidateService(DataDbContext context)
		{
			_context = context;
		}

		public async Task<int> Create(CandidateRequest candidateRequest)
		{
			var candidate = new Candidate()
			{
				Name = candidateRequest.Name,
				Email = candidateRequest.Email,
				Phone = candidateRequest.Phone,
				Introduction = candidateRequest.Introduction,
				Resume = candidateRequest.Resume,
				CandicateId = candidateRequest.CandicateId,
				Candicate = candidateRequest.Candicate,
				JobId = candidateRequest.JobId,
				Job = candidateRequest.Job,
				CreatedOn = candidateRequest.CreatedOn,
				UpdatedOn = candidateRequest.UpdatedOn,
				IsActive = candidateRequest.IsActive
			};
			_context.JobCandidates.Add(candidate);

			return await _context.SaveChangesAsync();
		}


		public Task<int> Delete(CandidateRequest candidateRequest)
		{
			var candidate = new Candidate()
			{
				Id = candidateRequest.Id
			};
			_context.JobCandidates.Remove(candidate);

			return _context.SaveChangesAsync();
		}

		public Task<int> Update(CandidateRequest candidateRequest)
		{
			var candidate = new Candidate()
			{
				Id = candidateRequest.Id,
				Name = candidateRequest.Name,
				Email = candidateRequest.Email,
				Phone = candidateRequest.Phone,
				Introduction = candidateRequest.Introduction,
				Resume = candidateRequest.Resume,
				CandicateId = candidateRequest.CandicateId,
				Candicate = candidateRequest.Candicate,
				JobId = candidateRequest.JobId,
				Job = candidateRequest.Job,
				CreatedOn = candidateRequest.CreatedOn,
				UpdatedOn = candidateRequest.UpdatedOn,
				IsActive = candidateRequest.IsActive
			};
			_context.JobCandidates.Update(candidate);

			return _context.SaveChangesAsync();
		}


		public async Task<List<CandidateResponse>> GetAll()
		{
			return await _context.JobCandidates
				.Select(x => new CandidateResponse()
				{
					Id = x.Id,
					Name = x.Name,
					Email = x.Email,
					Phone = x.Phone,
					Introduction = x.Introduction,
					Resume = x.Resume,
					CandicateId = x.CandicateId,
					Candicate = x.Candicate,
					JobId = x.JobId,
					Job = x.Job,
					CreatedOn = x.CreatedOn,
					UpdatedOn = x.UpdatedOn,
					IsActive = x.IsActive
				}).ToListAsync();
		}

		public async Task<Candidate> Details(Guid? id)
		{
			return await _context.JobCandidates.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<Candidate> FindById(Guid? id)
		{
			return await _context.JobCandidates.FindAsync(id);
		}
	}
}
