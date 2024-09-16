using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvvWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera", Description="Kamera ürünleri"},
                new Category(){Name="Bilgisayar", Description="Bilgisayar ürünleri"},
                new Category(){Name="Elektronik", Description="Elektronik ürünleri"},
                new Category(){Name="Telefon", Description="Telefon ürünleri"},
                new Category(){Name="Beyaz Eşya", Description="Beyaz Eşya ürünleri"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                // Kamera Kategorisi
                new Product(){Name="Canon EOS 5D", Description="Profesyonel DSLR Kamera", Price=15000, Stock=10, IsApproved=false, CategoryId=1,IsHome=true,Image="1.jpg"},
                new Product(){Name="Sony Alpha 7R", Description="Mirrorless Fotoğraf Makinesi", Price=18000, Stock=8, IsApproved=false, CategoryId=1,Image="2.jpg"},

                // Bilgisayar Kategorisi
                new Product(){Name="Dell XPS 13", Description="13 inç Ultrabook", Price=12000, Stock=15, IsApproved=true, CategoryId=2,IsHome=true,Image="3.jpg"},
                new Product(){Name="MacBook Pro", Description="16 inç Profesyonel Laptop", Price=25000, Stock=5, IsApproved=true, CategoryId=2,Image="4.jpg"},

                // Elektronik Kategorisi
                new Product(){Name="LG OLED TV", Description="55 inç 4K UHD Smart TV", Price=8000, Stock=12, IsApproved=false, CategoryId=3,IsHome=true,Image="1.jpg"},
                new Product(){Name="Sony PlayStation 5", Description="Yeni Nesil Oyun Konsolu", Price=9000, Stock=20, IsApproved=true, CategoryId=3,Image="2.jpg"},

                // Telefon Kategorisi
                new Product(){Name="iPhone 14", Description="Apple Akıllı Telefon", Price=24000, Stock=18, IsApproved=true, CategoryId=4,IsHome=true,Image="3.jpg"},
                new Product(){Name="Samsung Galaxy S23", Description="Android Amiral Gemisi", Price=22000, Stock=25, IsApproved=true, CategoryId=4,Image="4.jpg"}

                // Beyaz Eşya Kategorisi
                //new Product(){Name="Bosch Buzdolabı", Description="Çift Kapılı No-Frost Buzdolabı", Price=7000, Stock=7, IsApproved=true, CategoryId=5},
                //new Product(){Name="Arçelik Çamaşır Makinesi", Description="8 kg Kapasiteli Çamaşır Makinesi", Price=5000, Stock=10, IsApproved=true, CategoryId=5}
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }


            base.Seed(context);
        }
    }
}