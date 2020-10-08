using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
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
                         select new PessoaAgendamento(pa.pessoaid, pa.agendamentoid, p.Nome, a.Local, a.DataInicio.ToLocalTime(), a.DataFim.Date.ToLocalTime());
            if (data.HasValue)
            {
                result = result.Where(x => x.DataInicio.Month == data.Value.Month && x.DataInicio.Year == data.Value.Year);
            }
            return result
                .OrderByDescending(x => x.DataInicio)
                .ToList();
        }

        public Boolean Adicionar(int[] ids, DateTime dataInicio, DateTime dataFim)
        {
            var result = from a in _context.agendamento
                         from p in _context.pessoa
                         from pa in _context.pessoaagendamento
                         where a.Id == pa.agendamentoid && p.Id == pa.pessoaid
                         select new PessoaAgendamento(pa.pessoaid, pa.agendamentoid, p.Nome, a.Local, a.DataInicio, a.DataFim);
            foreach (var id in ids)
            {
                foreach (var obj in result)
                {
                    if (obj.pessoaid == id && ((dataInicio > obj.DataInicio && dataFim < obj.DataFim) ||
                                              (dataInicio < obj.DataInicio && dataFim < obj.DataFim) ||
                                              (dataInicio > obj.DataInicio && dataFim > obj.DataFim) ||
                                              (dataInicio < obj.DataInicio && dataFim > obj.DataFim)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public Boolean Atualizar(int id, DateTime dataInicio, DateTime dataFim)
        {
            var result = from a in _context.agendamento
                         select a;
            foreach (var obj in result)
            {
                if (obj.Id == id && ((dataInicio > obj.DataInicio && dataFim < obj.DataFim) ||
                                     (dataInicio < obj.DataInicio && dataFim < obj.DataFim) ||
                                     (dataInicio > obj.DataInicio && dataFim > obj.DataFim) ||
                                     (dataInicio < obj.DataInicio && dataFim > obj.DataFim)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
