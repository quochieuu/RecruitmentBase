﻿using Recruitment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Application.MFeedback
{
    public class FeedbackRequest
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime CommentOn { get; set; }
        public Guid JobId { get; set; }
        public Job Job { get; set; }
    }
}
