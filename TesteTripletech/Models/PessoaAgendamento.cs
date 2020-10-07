using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTripletech.Models
{
    public class PessoaAgendamento
    {
        public int? Id { get; set; }
        public int pessoaid { get; set; }
        public int agendamentoid { get; set; }
#nullable enable
        public string? Nome { get; set; }
#nullable enable
        public string? Local { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

        public PessoaAgendamento(int pessoaid, int agendamentoid)
        {
            this.pessoaid = pessoaid;
            this.agendamentoid = agendamentoid;
        }

        public PessoaAgendamento(int pessoaid, int agendamentoid, string? nome, string? local, DateTime? dataInicio, DateTime? dataFim) : this(pessoaid, agendamentoid)
        {
            Nome = nome;
            Local = local;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
    }
}
