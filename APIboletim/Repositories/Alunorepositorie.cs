using APIboletim.Context;
using APIboletim.Domains;
using APIboletim.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace APIboletim.Repositories
{
    public class Alunorepositorie : IAluno
    { 

        BoletimContext conexao = new  BoletimContext();

        SqlCommand cmd = new SqlCommand();
        
        public Aluno Alterar(Aluno a)
        {
            throw new NotImplementedException();
        }
        public Aluno BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Aluno Cadastrar(Aluno a)
        {
            throw new NotImplementedException();
        }

        public Aluno Excluir(Aluno a)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> LerTodos()
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "SELECT * FROM Aluno";

            SqlDataReader dados = cmd.ExecuteReader();

            List<Aluno> alunos = new List<Aluno>();

            while (dados.Read())
            {
                new Aluno()
                {
                    IdAuno = Convert.ToInt32(dados.GetValue(0)),
                    Nome = dados.GetValue(1).ToString()
                }
            }

            conexao.Desconectar();

            return alunos;
        }
    }
}
