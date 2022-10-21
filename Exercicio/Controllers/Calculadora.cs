using Exercicio.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Calculadora : ControllerBase
    {
        [HttpPost]
        public ActionResult<CalculadoraDTO> Post(decimal v1, decimal v2, decimal v3)
        {
            var resultado = new CalculadoraDTO();
           
            var soma = v1 + v2 + v3;
            var par = true;

            if (soma % 2 == 0)
            {
                par = true;
            }
            else
            {
                par = false;
            }
           
            resultado.Numero = soma;
            resultado.Par = par;

            return Ok(resultado);
           
        }



    }
}
