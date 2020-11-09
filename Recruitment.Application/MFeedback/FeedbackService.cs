using Microsoft.EntityFrameworkCore;
using Recruitment.Data.DataContext;
using Recruitment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Application.MFeedback
{
    public class FeedbackService : IFeedbackService
    {
		private readonly DataDbContext _context;

		public FeedbackService(DataDbContext context)
		{
			_context = context;
		}

		public async Task<int> Create(FeedbackRequest feedbackRequest)
		{
			var feedback = new Feedback()
			{
				Comment = feedbackRequest.Comment,
				Name = feedbackRequest.Name,
				Rating = feedbackRequest.Rating,
				CommentOn = feedbackRequest.CommentOn,
				UserId = feedbackRequest.UserId,
				CommentBy = feedbackRequest.CommentBy,
				Job = feedbackRequest.Job,
				JobId = feedbackRequest.JobId
			};
			_context.Feedbacks.Add(feedback);

			return await _context.SaveChangesAsync();
		}


		public Task<int> Delete(FeedbackRequest feedbackRequest)
		{
			var feedback = new Feedback()
			{
				Id = feedbackRequest.Id
			};
			_context.Feedbacks.Remove(feedback);

			return _context.SaveChangesAsync();
		}

		public Task<int> Update(FeedbackRequest feedbackRequest)
		{
			var feedback = new Feedback()
			{
				Id = feedbackRequest.Id,
				Comment = feedbackRequest.Comment,
				Name = feedbackRequest.Name,
				Rating = feedbackRequest.Rating,
				UserId = feedbackRequest.UserId,
				CommentOn = feedbackRequest.CommentOn,
				CommentBy = feedbackRequest.CommentBy,
				Job = feedbackRequest.Job,
				JobId = feedbackRequest.JobId
			};
			_context.Feedbacks.Update(feedback);

			return _context.SaveChangesAsync();
		}


		public async Task<List<FeedbackResponse>> GetAll()
		{
			return await _context.Feedbacks
				.Select(x => new FeedbackResponse()
				{
					Id = x.Id,
					Comment = x.Comment,
					Name = x.Name,
					Rating = x.Rating,
					UserId = x.UserId,
					CommentOn = x.CommentOn,
					CommentBy = x.CommentBy,
					Job = x.Job,
					JobId = x.JobId
				}).ToListAsync();
		}

		public async Task<Feedback> Details(Guid? id)
		{
			return await _context.Feedbacks.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task<Feedback> FindById(Guid? id)
		{
			return await _context.Feedbacks.FindAsync(id);
		}
	}
}
