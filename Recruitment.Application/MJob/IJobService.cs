using Recruitment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Application.MJob
{
    public interface IJobService
    {
        public Task<int> Create(JobRequest request);

        public Task<int> Update(JobRequest request);

        public Task<Job> Details(Guid? id);

        public Task<int> Delete(JobRequest request);

        public Task<List<JobResponse>> GetAll();

        public Task<Job> FindById(Guid? id);
    }
}
