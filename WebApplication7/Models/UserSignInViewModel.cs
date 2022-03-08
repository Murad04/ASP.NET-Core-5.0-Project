using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Kullanici ad giriniz")]
        public string username { get; set; }
        [Required(ErrorMessage = "Sifre  giriniz")]
        public string password { get; set; }
    }
}
