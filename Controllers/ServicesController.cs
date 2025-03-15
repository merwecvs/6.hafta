using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers{
    public class ServicesController : Controller{
        public IActionResult Index(){
            var hizmet = new Services();
            hizmet.Id = 1;
            hizmet.Title = "Ana Sayfa";
            hizmet.Description = "Hizmetlere Genel Bakış";
            return View(hizmet);
        }

        public IActionResult List(){
            var hizmetler = new List<Services>(){
                new Services() {Id = 1, Title = "Ev Elektrik Hizmetleri", Description = "Tesisat, priz & anahtar montajı."},
                new Services() {Id = 2, Title = "Endüstriyel Elektrik Hizmetleri", Description = "Fabrika ve büyük tesisat işlemleri."},
                new Services() {Id = 3, Title = "Acil Elektrikçi Hizmetleri", Description = "Kesinti, kısa devre, arıza onarımı."},
                new Services() {Id = 4, Title = "Aydınlatma Çözümleri", Description = "LED, spot, bahçe aydınlatması."},
                new Services() {Id = 5, Title = "Akıllı Ev Sistemleri", Description = "Otomasyon, IoT çözümleri."}
            };
            return View(hizmetler);
        }
    }
}