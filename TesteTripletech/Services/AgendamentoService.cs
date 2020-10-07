using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTripletech.Models;

namespace TesteTripletech.Services
{
    public class AgendamentoService
    {
        private readonly DatabaseContext _context;
        public AgendamentoService(DatabaseContext context)
        {
            _context = context;
        }
        public List<PessoaAgendamento> FindByDate(DateTime? data)
        {
            var result = from a in _context.agendamento
                         from p in _context.pessoa
                         from pa in _context.pessoaagendamento
                         where a.Id == pa.agendamentoid && p.Id == pa.pessoaid
                         select new PessoaAgendamento(pa.pessoaid, pa.agendamentoid, p.Nome, a.Local, a.DataInicio, a.DataFim);
            if (data.HasValue)
            {
                result = result.Where(x => x.DataInicio.Value.Month == data.Value.Month && x.DataInicio.Value.Year == data.Value.Year);
            }
            return result
                .OrderByDescending(x => x.DataInicio)
                .ToList();
        }
    }
}
