namespace Biblioteca.Models
{
    public static class DadosBiblioteca
    {
        public static List<Autor> Autores = new List<Autor>
        {
            new Autor
            {
                Id = 1,
                Nome = "Machado de Assis",
                DataNascimento = new DateTime (1839, 06, 21),
                FotoUrl = "/images/Machado_de_Assis.jpg",
                Biografia = "Machado de Assis foi um dos maiores escritores da literatura brasileira."
            },
            new Autor
            {
                Id = 2,
                Nome = "Clarice Lispector",
                DataNascimento = new DateTime (1920, 12, 10),
                FotoUrl = "/images/Clarice.jpg",
                Biografia = "Clarice Lispector foi escritora e jornalista, reconhecida por sua escrita introspectiva."
            },
            new Autor
            {
                Id = 3,
                Nome = "Bram Stoker",
                DataNascimento = new DateTime (1847, 09, 08),
                FotoUrl = "/images/Bram_Stoker.jpg",
                Biografia = "Abraham 'Bram' Stoker foi um romancista, poeta e contista irlandês, mundialmente conhecido por seu romance gótico Drácula, a mais conhecida obra a marcar o desenvolvimento do mito literário moderno do vampiro."

            }
        };

        public static List<Livro> Livros = new List<Livro>
        {
            new Livro
            {
                Id = 1,
                Titulo = "Dom Casmurro",
                CapaUrl = "/images/Dom_Casmurro.jpg",
                Descricao = "Um clássico da literatura brasileira que aborda memória, ciúme e relações humanas.",
                PdfUrl = "https://www.curso-objetivo.br/vestibular/assets/download/obras-literarias/machado-de-assis/dom-casmurro.pdf",
                AnoPublicacao = 1899,
                QuantidadePaginas = 256,
                AutorId = 1
            },
            new Livro
            {
                Id = 2,
                Titulo = "Memórias Póstumas de Brás Cubas",
                CapaUrl = "/images/Mem_Postumas.png",
                Descricao = "Uma narrativa inovadora e irônica, considerada uma das principais obras de Machado de Assis.",
                PdfUrl = "https://share.google/EB7kl0y8ebzxdhrdc",
                AnoPublicacao = 1881,
                QuantidadePaginas = 256,
                AutorId = 1
            },
            new Livro
            {
                Id = 3,
                Titulo = "A Hora da Estrela",
                CapaUrl = "/images/A_Hora_da_Estrela.png",
                PdfUrl = "https://share.google/kjxTOLlhz0U0Rx5ec",
                Descricao = "Romance marcante que narra a trajetória de Macabéa de forma profunda e sensível.",
                AnoPublicacao = 1977,
                QuantidadePaginas = 256,
                AutorId = 2
            },
            new Livro
            {
                Id = 4,
                Titulo = "Dracula",
                CapaUrl = "/images/Dracula.jpg",
                Descricao = "Romance importante da literatura brasileira que retrata a vida no sertão nordestino.",
                PdfUrl = "https://bramstoker.org/pdf/novels/05dracula.pdf",
                AnoPublicacao = 1897,
                QuantidadePaginas = 353,
                AutorId = 3
            }
        };
    }
}