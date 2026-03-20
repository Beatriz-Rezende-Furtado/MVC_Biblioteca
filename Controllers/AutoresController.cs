using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class AutoresController : Controller
    {
        public IActionResult Details(int id)
        {
            var autor = DadosBiblioteca.Autores.FirstOrDefault(a => a.Id == id);

            if (autor == null)
                return NotFound();

            ViewBag.LivrosDoAutor = DadosBiblioteca.Livros.Where(l => l.AutorId == id).ToList();

            return View(autor);
        }
    }
}