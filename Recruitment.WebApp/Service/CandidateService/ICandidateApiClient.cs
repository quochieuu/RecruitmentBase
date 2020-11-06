using Recruitment.Application.MCandidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.WebApp.Service.CandidateService
{
    public interface ICandidateApiClient
    {
        public Task<string> GetAll();

        public Task<string> Create(CandidateRequest request);

        public Task<string> Update(CandidateRequest request);

        public Task<string> Delete(CandidateRequest request);

        public Task<string> Details(Guid? id);

        public Task<string> FindById(Guid? id);
    }
}
