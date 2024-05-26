using Microsoft.AspNetCore.Mvc;
using MVC_Temelleri.Models;


namespace MVC_Temelleri.Controllers
{
    public class XYZController : Controller
    {
        private static List<XYZ> xyzs = new List<XYZ>
        {
            new XYZ{Id =1,isim="Hasan",Soyisim="Demirci",Yas=23},
            new XYZ{Id =1,isim="Hamdi",Soyisim="Tasyürek",Yas=32},
            new XYZ{Id =1,isim="Sahin",Soyisim="Onurtekin",Yas=29},
        };

        [HttpGet("/XYZ")]
        public IActionResult Index()
        {
            return View(xyzs);
        }
    }
}
