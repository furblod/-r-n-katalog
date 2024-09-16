using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvvWebUI.Models
{
    public class ShippingDetails
    {
        public string Username { get; set; }
        [Required(ErrorMessage ="Lütfen Adres başlığını giriniz.")]
        public string AdresBasligi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Semt { get; set; }
        public string Mahalle { get; set; }
        public string PostaKodu { get; set; }
    }
}