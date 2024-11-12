using BibliotecaLivros.Models;

namespace BibliotecaLivros.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string? Titulo { get; set; }
        public AutorModel? Autor { get; set; }
    }
}
