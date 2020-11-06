using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.WebApp.Areas.Admin.ViewModel
{
    public class FileDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Direct { get; set; }
    }

    public class FilesViewModel
    {
        public List<FileDetails> Files { get; set; }
            = new List<FileDetails>();
    }
}
