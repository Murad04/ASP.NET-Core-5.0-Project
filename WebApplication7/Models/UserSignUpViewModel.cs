using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad soyad")]
        [Required(ErrorMessage ="Ad soyad giriniz")]
        public string nameSurname { get; set; }

        [Display(Name = "Sifre")]
        [Required(ErrorMessage = "Sifre giriniz")]
        public string Password { get; set; }


        [Display(Name = "Sifre tekrar yazin")]
        [Compare("Password",ErrorMessage ="Sifreler uygun deyil")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Mail adresi yazin")]
        [Required(ErrorMessage = "Mail adresi giriniz")]
        public string Mail { get; set; }


        [Display(Name = "Kullanici adi")]
        [Required(ErrorMessage = "Kullanici adinizi giriniz")]
        public string Username { get; set; }
    }
}
