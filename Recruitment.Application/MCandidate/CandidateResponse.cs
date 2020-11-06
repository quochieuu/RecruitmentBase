using Recruitment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Application.MCandidate
{
    public class CandidateResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Introduction { get; set; }
        public string Resume { get; set; }

        public Guid CandicateId { get; set; }
        public AppUser Candicate { get; set; }
        public Guid JobId { get; set; }
        public Job Job { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
