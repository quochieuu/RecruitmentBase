using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.WebApp.Areas.Admin.ViewModel
{ 
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public Guid Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Website { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }
        public string UrlAvatar{ get; set; }

        public List<string> Claims { get; set; }

        public IList<string> Roles { get; set; }
    }

}
