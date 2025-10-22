using Microsoft.AspNetCore.Mvc;
using movieDB.Aplicacao.Servicos;
using movieDB.Dominio.Entidades;

namespace movieDB.Apresentacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {
        private FilmesServicos servicos;
        public FilmesController() 
        {
            servicos = new FilmesServicos();
        }
        [HttpGet]

        private IActionResult get(Filme filme)
        {
            servicos.BuscarFilmePorNome(filme.Titulo);
            return Ok();
        }
        [HttpPost]
        private IActionResult post(Filme filme)
        {
            servicos.CriaFilme(filme);
            return Ok();
        }
        [HttpPut]
        private IActionResult put(Filme filme)
        {
            servicos.AtualizaFilme(filme);
            return Ok();
        }
        [HttpDelete]
        private IActionResult delete(Filme filme) 
        {
            servicos.DeletaFilme(filme);
            return Ok(); 
        }
    }
}
