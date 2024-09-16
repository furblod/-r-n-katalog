using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvvWebUI.Models
{
    public class Register
    {
        [Required]
        [Display(Name="Adınız")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Soyadınız")]
        public string SurName { get; set; }
        [Required]
        [Display(Name = "Kullanıcı Adınız")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Eposta Adresi")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Şifre tekrarı")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string RePassword { get; set; }
    }
}