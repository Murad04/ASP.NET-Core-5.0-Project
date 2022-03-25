using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Rol adi yaziniz")]
        public string Name { get; set; }
    }
}
