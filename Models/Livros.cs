namespace Biblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string CapaUrl { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; } 
        public int QuantidadePaginas { get; set; }
        
        public string Resumo { get; set; } = string.Empty;
        
        public string? PdfUrl { get; set; }
        public int AutorId { get; set; }
        public Autor? Autor { get; set; }
    }
}