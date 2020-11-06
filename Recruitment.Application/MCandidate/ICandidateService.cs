using Recruitment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Application.MCandidate
{
    public interface ICandidateService
    {
        public Task<int> Create(CandidateRequest request);

        public Task<int> Update(CandidateRequest request);

        public Task<Candidate> Details(Guid? id);

        public Task<int> Delete(CandidateRequest request);

        public Task<List<CandidateResponse>> GetAll();

        public Task<Candidate> FindById(Guid? id);
    }
}
