using Empresa.Endereco.Servico.ViaCep;
using Microsoft.AspNetCore.Mvc;

namespace Empresa.Endereco.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController:ControllerBase
    {
        [HttpGet(Name ="GetEndereco")]
        public async Task<IActionResult> ObterEnderecos(string cep)
        {
            var requisicao = await new ViaCepService().ObterEnderecoPorCep(cep);
            return Ok(requisicao);
        }
    }
}
