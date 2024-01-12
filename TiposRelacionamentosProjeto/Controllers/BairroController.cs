using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiposRelacionamentosProjeto.Data;
using TiposRelacionamentosProjeto.Dtos;
using TiposRelacionamentosProjeto.Models;

namespace TiposRelacionamentosProjeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BairroController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BairroController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> criarCasa(CasaCriacaoDto casa)
        {
            var novaCasa = new CasaModel()
            {
                Descricao = casa.Descricao
            };


            var endereco = new EnderecoModel()
            {

                Rua = casa.endereco.Rua,
                Numero = casa.endereco.Numero
            };

            var quartos = casa.quartos.Select(q => new QuartoModel { Descricao = q.Descricao, Casa = novaCasa}).ToList();
            var moradores = casa.moradores.Select(m => new MoradorModel { Nome = m.Nome, Casas = new List<CasaModel> { novaCasa } }).ToList();

            novaCasa.Endereco = endereco;
            novaCasa.Quartos = quartos;
            novaCasa.Moradores = moradores;


            _context.Casas.Add(novaCasa);
            await _context.SaveChangesAsync();

            return Ok(await _context.Casas.Include(e => e.Endereco).Include(q => q.Quartos).Include(m => m.Moradores).ToListAsync());

        }

    }
}
