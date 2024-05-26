using Microsoft.AspNetCore.Mvc;
using MVC_Temelleri.Models;


namespace MVC_Temelleri.Controllers
{
    public class XYZController : Controller
    {
        private static List<XYZ> xyzs = new List<XYZ>
        {
            new XYZ{Id =1,isim="Hasan",Soyisim="Demirci",Yas=23,Maas=45000},
            new XYZ{Id =2,isim="Hamdi",Soyisim="Tasyürek",Yas=32,Maas=28000},
            new XYZ{Id =3,isim="Sahin",Soyisim="Onurtekin",Yas=29,Maas=38000},
        };

        [HttpGet("/XYZ")]
        public IActionResult Index()
        {
            return View(xyzs);
        }
    }
}
