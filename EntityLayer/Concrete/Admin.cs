using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }
        public string AdminName { get; set; }
        public string AdminBio { get; set; }
        public string AdminImage { get; set; }
        public string AdminRole { get; set; }
    }
}
