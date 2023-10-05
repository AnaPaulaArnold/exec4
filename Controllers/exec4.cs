using System;
using Microsoft.AspNetCore.Mvc;

/*
Exec4 - Web Services
Autor: Ana Paula Abreu Arnold
RU: 3805422
*/

[Route("api/exec4")] // Definição da Rota da Controller
[ApiController]
public class Exec4Controller : ControllerBase
{
    [HttpGet("alunoRU")] // Definindo Método para endpoint "api/exec4/alunoRU"
    public IActionResult AlunoRU()
    {
        // Instanciando novo objeto Aluno, definindo Nome e RU 
       var dadosAluno = new Aluno{
        Nome = "Ana Paula Abreu Arnold",
        RU = 3805422
       };
        return Ok(dadosAluno); // Retornando dados para WEB como objeto
    }

    [HttpGet("pitagoras")] // Definindo método para retorno do cálculo de pitagora para o endpoint "api/exec4/pitagoras"
    public IActionResult Pitagoras()
    {
        // fórmula: c^2 = a^2 + b^2
        // Instanciando novo objeto para Pitagoras
        var pitagoras = new Pitagoras{
            B = 3, // Primeiro dígito do RU
            C = 8, // Segundo dígito do RU
            A = 0 // Valor a calcular
        };

        pitagoras.A = (int)Math.Sqrt(Math.Pow(pitagoras.C, 2 ) - Math.Pow(pitagoras.B, 2)); // Substituindo os valores, calculando valor de "a"
        //e fazendo conversão para int
       
        return Ok(pitagoras); //Retornando valores de "a", "b" e "c" como objeto
    }

}
