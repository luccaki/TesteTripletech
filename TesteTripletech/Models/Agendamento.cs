using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTripletech.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Agendamento(int id, string local, DateTime dataInicio, DateTime dataFim)
        {
            Id = id;
            Local = local;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
    }
}
