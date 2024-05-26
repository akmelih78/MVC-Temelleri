using Microsoft.AspNetCore.Mvc;
using MVC_Temelleri.Models;

namespace MVC_Temelleri.Controllers
{
    public class PizzaController : Controller
    {
        [Route("PizzaSiparis")]
        
        public IActionResult Index()
        {
            Pizza pizza = new Pizza()

            {
                isim = "margherita",
                malzeme = "Domates,peynir,feslegen",
                fiyat = 300.00m

            
            
            
            };
            
            
            
            
            
            
            return View(pizza);
        }
    }
}
