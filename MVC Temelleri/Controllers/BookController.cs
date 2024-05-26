using Microsoft.AspNetCore.Mvc;
using MVC_Temelleri.Models;

namespace MVC_Temelleri.Controllers
{
    public class BookController : Controller
    {

        private static List<Book> books = new List<Book>
        {
            new Book{Id = 1, Title ="Harry Porter", Author= "J.K.Rowling"},
            new Book{Id = 2, Title ="Seker Portakali", Author= "José Mauro de Vasconcelos"},
            new Book{Id = 3, Title ="Severek Dinliyoruz", Author= "Nihat Sirdar"},
            new Book{Id = 4, Title ="35`i Beklerken", Author= "Nihat Sirdar"},
            new Book{Id = 5, Title ="Dar Agacinda 3 Fidan", Author= "Nihat Behram"},
        };

        [HttpGet("/books")]
        public IActionResult Index()
        {

            return View(books);
        }

        [HttpGet("/Books/Create")]
        public IActionResult Create()
        {
            return View(); 
        
        }
        [HttpPost("/Books/Create")]
        public IActionResult Edit(Book book)
        {
            book.Id = books.Count + 1;
            books.Add(book);
            return RedirectToAction("Index");
        }
    }
}
