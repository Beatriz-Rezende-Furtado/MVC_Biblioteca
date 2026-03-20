namespace Biblioteca.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; } 
        public string FotoUrl { get; set; } = string.Empty;
        public string Biografia { get; set; } = string.Empty;
        public virtual ICollection<Livro> Livros { get; set; } = new List<Livro>();
    }
}