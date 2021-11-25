using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/Controller")]
    public class AlunoController : ControllerBase
    {

        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome = "Rodrigo",
                Sobrenome = "Rosa",
                Telefone = "32434435990"    
            },
            new Aluno(){
                Id = 2,
                Nome = "Anan",
                Sobrenome = "Carolina",
                Telefone = "12345456590"    
            },
            new Aluno(){
                Id = 3,
                Nome = "Pedro",
                Sobrenome = "Rosa",
                Telefone = "32930240099"    
            },

        };

        public AlunoController() { }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{Id}")]
        public IActionResult GetById(int Id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == Id);
            if(aluno == null) return BadRequest("O aluno não foi encontrado");
            
            return Ok(Alunos);
        }
        

        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string Sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => 
                a.Nome.Contains(nome) && a.Sobrenome.Contains(Sobrenome));
            if(aluno == null) return BadRequest("O aluno não foi encontrado");
            
            return Ok(Alunos);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}