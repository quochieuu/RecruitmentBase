using Recruitment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Application.MFeedback
{
    public class FeedbackResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime CommentOn { get; set; }
        public Guid UserId { get; set; }
        public AppUser CommentBy { get; set; }
        public Guid JobId { get; set; }
        public Job Job { get; set; }
    }
}
