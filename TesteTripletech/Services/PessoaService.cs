using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTripletech.Models;

namespace TesteTripletech.Services
{
    public class PessoaService
    {
        private readonly DatabaseContext _context;
        public PessoaService(DatabaseContext context)
        {
            _context = context;
        }
        public List<Pessoa> FindAll()
        {
            return _context.pessoa.ToList();
        }
    }
}
