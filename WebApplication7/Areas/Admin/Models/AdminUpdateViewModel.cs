using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Areas.Admin.Models
{
    public class AdminUpdateViewModel
    {
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }
        public string AdminName { get; set; }
        public string AdminBio { get; set; }
        public string AdminImage { get; set; }
    }
}
