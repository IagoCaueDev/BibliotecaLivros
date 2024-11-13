using BibliotecaLivros.Dto.Livro;
using BibliotecaLivros.Models;
using BibliotecaLivros.Services.Livro;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaLivros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LivroController : ControllerBase
    {
        private ILivroInterface _livrointeface;

        public LivroController(ILivroInterface livroInterface)
        {
            _livrointeface = livroInterface;
        }

        [HttpGet]
        [Route("Listar")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> Listar()
        {
            var livros = await _livrointeface.Listar();
            return Ok(livros);
        }

        [HttpGet]
        [Route("BuscarLivroId/{idAutor}")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivroId(int idLivro)
        {
            var livros = await _livrointeface.BuscarLivroId(idLivro);
            return Ok(livros);
        }

        [HttpPost]
        [Route("Criar")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> CriarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            var livros = await _livrointeface.CriarAutor(livroCriacaoDto);
            return Ok(livros);
        }

        [HttpPut]
        [Route("Editar")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> EditarLivro(LivroEdicaoDto livroEdicaoDto)
        {
            var livros = await _livrointeface.EditarLivro(livroEdicaoDto);
            return Ok(livros);
        }

        [HttpDelete]
        [Route("Excluir")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> ExcluirLivro(int idLivro)
        {
            var livros = await _livrointeface.ExcluirLivro(idLivro);
            return Ok(livros);
        }

    }
}
