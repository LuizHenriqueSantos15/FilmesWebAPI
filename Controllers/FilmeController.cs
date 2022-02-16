using LojaRoupaAPIWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaRoupaAPIWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmeController : Controller
    {
        [HttpGet]

        public ActionResult Get()
        {
            using (var contexto = new FilmeContext())
            {
                var filmes = contexto.Filmes.ToList();

                return Ok(filmes);
            }
        }

        [HttpGet("{produtora}")]

        public ActionResult GetByProdutora(string produtora)
        {
            using (var contexto = new FilmeContext())
            {
                var filmes = (from s in contexto.Filmes where s.Produtora.Contains(produtora) select s).ToList();

                //var filmes = contexto.Filmes.ToList();

                return Ok(filmes);
            }
        }

        [HttpGet("/api/[controller]/buscar/{filme}")]

        public ActionResult GetByFilme(string filme)
        {
            using (var contexto = new FilmeContext())
            {
                var filmes = (from s in contexto.Filmes where s.Nome.Contains(filme) select s).ToList();

                //var filmes = contexto.Filmes.ToList();

                return Ok(filmes);
            }
        }
    }
}
