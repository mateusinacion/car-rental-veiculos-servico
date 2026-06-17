using Microsoft.AspNetCore.Mvc;
using Servicos;
using Veiculos.DTO;

namespace Veiculos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly VeiculoDomain _veiculoDomain;

        public VeiculosController()
        {
            _veiculoDomain = new VeiculoDomain();
        }

        [HttpPost]
        public IActionResult Inserir(InserirVeiculoDTO dadosDaInsercao)
        {
            try
            {
                _veiculoDomain.Inserir(dadosDaInsercao);

                return Ok("Veículo inserido com sucesso");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Alterar([FromRoute] int id, [FromBody] EditarVeiculoDTO dadosDaAlteracao)
        {
            try
            {
                _veiculoDomain.Alterar(id, dadosDaAlteracao);

                return Ok("Veículo alterado com sucesso");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet]
        public IActionResult BuscarVeiculos()
        {
            try
            {
                var veiculos = _veiculoDomain.BuscarVeiculos();

                return Ok(veiculos);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("/api/[controller]/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                var veiculo = _veiculoDomain.BuscarPorId(id);

                if (veiculo == null)
                {
                    return NotFound();
                }

                return Ok(veiculo);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("/api/[controller]/AlterarStatus/{id}")]
        public IActionResult AlterarStatus
            ([FromRoute] int id, [FromBody] AlterarStatusDTO alterarStatusDto)
        {
            try
            {
                _veiculoDomain.AlterarStatus(id, alterarStatusDto);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
