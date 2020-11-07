using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Recruitment.Data.Entities
{
    public class Candidate
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Hãy nhập tên ứng tuyển")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "please enter correct address")]
        [Required(ErrorMessage = "Hãy nhập email ứng tuyển")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hãy nhập số điện thoại ứng tuyển")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Hãy nhập mô tả ngắn")]
        public string Introduction { get; set; }

        [Required(ErrorMessage = "Hãy tải lên hồ sơ của bạn")]
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
