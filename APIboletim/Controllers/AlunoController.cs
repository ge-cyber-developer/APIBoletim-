using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIboletim.Repository;
using APIboletim.Domains;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIboletim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        AlunoRepository repo = new AlunoRepository();

        // GET: api/<AlunoController>
        // <summary>
        // Ler todos os alunos
        // </summary>
        // <returns>Retorna todos os alunos.</returns>
        [HttpGet]
        public List<Aluno> Get()
        {
            return repo.LerTodos();
        }

        // GET: api/<AlunoController>/5
        // <summary>
        // Retornar aluno via id
        // </summary>
        // <param name='id'></param>
        // <returns>Retorna Aluno com determinado ID.</returns>

        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return repo.BuscarPorId(id);
        }

        // POST api/<AlunoController>
        // <summary>
        // Cadastrar usuario
        // </summary>
        // <param name='a'>Aluno a ser cadastrado</param>
        // <returns>Retorna Aluno cadastrado.</returns>

        [HttpPost]
        public Aluno Post([FromBody] Aluno a)
        {
            return repo.Cadastrar(a);
        }

        // PUT api/<AlunoController>/5
        // <summary>
        // Atualizar aluno
        // </summary>
        // <param name='id'>id do usuario a ser atualizado</param>
        // <param name='Aluno'>Aluno com as informações atualizadas.</param>
        // <returns>Retorna Aluno atualizado.</returns>

        [HttpPut("{id}")]
        public Aluno Put(int id, [FromBody] Aluno a)
        {
            return repo.Alterar(id, a);
        }

        // DELETE api/<AlunoController>/5
        // <summary>
        // Deletar aluno
        // </summary>
        // <param name='id'>id do usuario a ser deletado</param>
        // <returns>Não retorna nenhum dado</returns>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Excluir(id);
        }
    }
}
