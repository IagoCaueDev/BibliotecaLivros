using BibliotecaLivros.Dto.Autor;
using BibliotecaLivros.Models;
using BibliotecaLivros.Services.Autor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaLivros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AutorController : ControllerBase
    {
        private readonly IAutorInterface _autorInterface;
        public AutorController(IAutorInterface autorInterface)
        {
            _autorInterface = autorInterface;
        }

        [HttpGet]
        [Route("Listar")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> Listar()
        {
            var autores = await _autorInterface.Listar();
            return Ok(autores);
        }

        [HttpGet]
        [Route("BuscarAutorId/{idAutor}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorId(int idAutor) 
        {
            var autor = await _autorInterface.BuscarAutorId(idAutor);
            return Ok(autor);
        }

        [HttpGet]
        [Route("BuscarLivroId/{idLivro}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarLivroId(int idLivro)
        {
            var autor = await _autorInterface.BuscarLivroId(idLivro);
            return Ok(autor);
        }

        [HttpPost]
        [Route("CriarAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> CriarAutor(AutorCriacaoDto autorCriacaoDto)
        {
            var autores = await _autorInterface.CriarAutor(autorCriacaoDto);
            return Ok(autores);
        }

        [HttpPut]
        [Route("EditarAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> EditarAutor(AutorEdicaoDto autorEdicaoDto)
        {
            var autores = await _autorInterface.EditarAutor(autorEdicaoDto);
            return Ok(autores);
        }

        [HttpDelete]
        [Route("ExcluirAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ExcluirAutor(int idAutor)
        {
            var autores = await _autorInterface.ExcluirAutor(idAutor);
            return Ok(autores);
        }

    }
}
