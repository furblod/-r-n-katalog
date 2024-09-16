using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvvWebUI.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name="Kategori Adı")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}