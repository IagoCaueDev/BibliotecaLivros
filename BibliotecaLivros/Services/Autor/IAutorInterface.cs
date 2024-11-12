using BibliotecaLivros.Dto.Autor;
using BibliotecaLivros.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace BibliotecaLivros.Services.Autor
{
    public interface IAutorInterface
    {
        Task<ResponseModel<List<AutorModel>>> Listar();
        Task<ResponseModel<AutorModel>> BuscarAutorId(int idAutor);
        Task<ResponseModel<AutorModel>> BuscarLivroId(int idLivro);
        Task<ResponseModel<List<AutorModel>>> CriarAutor(AutorCriacaoDto autorCriacaoDto);
        Task<ResponseModel<List<AutorModel>>> EditarAutor(AutorEdicaoDto autorEdicaoDto);
        Task<ResponseModel<List<AutorModel>>> ExcluirAutor(int idAutor);
    }
}
