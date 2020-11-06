using Recruitment.Application.MJob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.WebApp.Service.JobService
{
    public interface IJobApiClient
    {
        public Task<string> GetAll();

        public Task<string> Create(JobRequest request);

        public Task<string> Update(JobRequest request);

        public Task<string> Delete(JobRequest request);

        public Task<string> Details(Guid? id);

        public Task<string> FindById(Guid? id);
    }
}
