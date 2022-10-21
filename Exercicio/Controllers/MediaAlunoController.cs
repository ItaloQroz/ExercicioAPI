using Exercicio.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaAlunoController : ControllerBase
    {
        [HttpPost]

        public ActionResult<MediaAlunoDTO> Post(string aluno,double nota1,double nota2, double nota3, double nota4)
        {

            var resultado = new MediaAlunoDTO();

            var media = (nota1 + nota2 + nota3 + nota4) / 4 
                ;

            resultado.aluno = aluno;
            resultado.media = media;


            if( media < 7)
            {
                resultado.situacao = "reprovado";
            }
            else
            {
                resultado.situacao = "aprovado";
            }


            return Ok(resultado);
        }

    }
}
