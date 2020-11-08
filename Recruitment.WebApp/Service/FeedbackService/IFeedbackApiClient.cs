using Recruitment.Application.MFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.WebApp.Service.FeedbackService
{
    public interface IFeedbackApiClient
    {
        public Task<string> GetAll();

        public Task<string> Create(FeedbackRequest request);

        public Task<string> Update(FeedbackRequest request);

        public Task<string> Delete(FeedbackRequest request);

        public Task<string> Details(Guid? id);

        public Task<string> FindById(Guid? id);
    }
}
