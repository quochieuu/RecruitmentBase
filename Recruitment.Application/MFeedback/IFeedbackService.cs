using Recruitment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Application.MFeedback
{
    public interface IFeedbackService
    {
        public Task<int> Create(FeedbackRequest request);

        public Task<int> Update(FeedbackRequest request);

        public Task<Feedback> Details(Guid? id);

        public Task<int> Delete(FeedbackRequest request);

        public Task<List<FeedbackResponse>> GetAll();

        public Task<Feedback> FindById(Guid? id);
    }
}
