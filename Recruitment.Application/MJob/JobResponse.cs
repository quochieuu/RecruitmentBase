using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Application.MJob
{
    public class JobResponse
    {
        public Guid Id { get; set; }

        public string Position { get; set; }
        public string Slug { get; set; }
        public string ApplicationEmail { get; set; }
        public string JobImage { get; set; }
        public string JobDetail { get; set; }
        public int Amount { get; set; }    // Số lượng tuyển dụng
        public String Experience { get; set; }    // Kinh nghiệm
        public decimal SalaryMin { get; set; }    // Lương tối thiểu
        public decimal SalaryMax { get; set; }    //  Lương tối đa
        public string SalaryUnit { get; set; }     //Đơn vị tiền lương
        public int WorkTime { get; set; }
        public string Address { get; set; }
        public DateTimeOffset DealineForSubmission { get; set; }     // Hạn cuối nộp đơn
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
