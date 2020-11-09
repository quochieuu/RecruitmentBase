using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Data.Entities
{
    public class Feedback
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
