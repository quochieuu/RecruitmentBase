using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Recruitment.Data.Entities
{
    public class Job
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Hãy nhập một vị trí ứng tuyển")]
        public string Position { get; set; }
        public string Slug { get; set; }
        [Required(ErrorMessage = "Hãy nhập địa chỉ email")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "please enter correct address")]
        public string ApplicationEmail { get; set; }
        [Required(ErrorMessage = "Hãy chọn ảnh cho vị trí ứng tuyển")]
        public string JobImage { get; set; }
        [Required(ErrorMessage = "Hãy nhập mô tả vị trí ứng tuyển")]
        public string JobDetail { get; set; }
        [Required(ErrorMessage = "Hãy nhập số lượng ứng tuyển")]
        public int Amount { get; set; }    // Số lượng tuyển dụng
        [Required(ErrorMessage = "Hãy nhập yêu cầu kinh nghiệm")]
        public String Experience { get; set; }    // Kinh nghiệm
        [Required(ErrorMessage = "Hãy nhập mức lương tối thiểu")]
        public decimal SalaryMin { get; set; }    // Lương tối thiểu
        [Required(ErrorMessage = "Hãy nhập mức lương tối đa")]
        public decimal SalaryMax { get; set; }    //  Lương tối đa
        [Required(ErrorMessage = "Hãy chọn đơn vị lương")]
        public string SalaryUnit { get; set; }     //Đơn vị tiền lương
        [Required(ErrorMessage = "Hãy nhập thời gian làm việc")]
        public int WorkTime { get; set; }
        [Required(ErrorMessage = "Hãy nhập địa chỉ làm việc")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Hãy chọn thời hạn nộp hồ sơ")]
        public DateTimeOffset DealineForSubmission { get; set; }     // Hạn cuối nộp đơn

        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset? UpdatedOn { get; set; }
        public bool IsActive { get; set; }

    }
}
