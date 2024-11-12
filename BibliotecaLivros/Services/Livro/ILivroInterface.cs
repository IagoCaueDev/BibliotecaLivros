using BibliotecaLivros.Dto.Autor;
using BibliotecaLivros.Dto.Livro;
using BibliotecaLivros.Models;

namespace BibliotecaLivros.Services.Livro
{
    public interface ILivroInterface
    {
        Task<ResponseModel<List<LivroModel>>> Listar();
        Task<ResponseModel<LivroModel>> BuscarLivroId(int idLivro);
        Task<ResponseModel<List<LivroModel>>> CriarAutor(LivroCriacaoDto livroCriacaoDto);
        Task<ResponseModel<List<LivroModel>>> EditarLivro(LivroEdicaoDto livroEdicaoDto);
        Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int idLivro);
    }
}
