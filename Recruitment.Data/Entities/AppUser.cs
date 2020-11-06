using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Recruitment.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public byte[] IdQrCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public bool? Gender { get; set; }
        public string Comment { get; set; }
        public string Address { get; set; }
        public string UrlAvatar { get; set; }
    }
}
