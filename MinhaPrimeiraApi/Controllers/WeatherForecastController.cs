using Microsoft.AspNetCore.Mvc;

namespace MinhaPrimeiraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //Classe
    public class TurmaDaTardeController : ControllerBase
    {
        //Propriedade


        public TurmaDaTardeController()
        {

        }

        [HttpGet("Diga_Boa_Tarde")]
        public string Get()
        {
            return "Boa Tarde Turma!!!";
        }


        [HttpGet("Diga-Seu-Nome")]
        public string GetNome(string nome)
        {
            return $"Seu nome é {nome}";
        }


        [HttpGet("Resultado-De-Uma-Soma")]
        public string GetSoma(int num1, int num2)
        {
            int resultado = num1 + num2;
            return $"O resultado da soma é {resultado}";
        }

    }
}