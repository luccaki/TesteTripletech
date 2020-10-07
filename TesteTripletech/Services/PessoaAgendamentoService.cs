using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTripletech.Models;

namespace TesteTripletech.Services
{
    public class PessoaAgendamentoService
    {
        private readonly DatabaseContext _context;
        public PessoaAgendamentoService(DatabaseContext context)
        {
            _context = context;
        }
        
    }
}
