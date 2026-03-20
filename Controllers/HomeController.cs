using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var livros = DadosBiblioteca.Livros;

            foreach (var livro in livros)
            {
                livro.Autor = DadosBiblioteca.Autores.FirstOrDefault(a => a.Id == livro.AutorId);
            }

            return View(livros);
        }
    }
}