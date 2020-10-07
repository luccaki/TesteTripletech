using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTripletech.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Pessoa(int id, string nome, DateTime dataDeNascimento, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Email = email;
            Telefone = telefone;
        }
    }
}
