using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Details(int id)
        {
            var livro = DadosBiblioteca.Livros.FirstOrDefault(l => l.Id == id);

            if (livro == null)
                return NotFound();

            livro.Autor = DadosBiblioteca.Autores.FirstOrDefault(a => a.Id == livro.AutorId);

            return View(livro);
        }
    }
}