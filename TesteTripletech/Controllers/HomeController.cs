using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteTripletech.Models;
using TesteTripletech.Services;

namespace TesteTripletech.Controllers
{
    public class HomeController : Controller
    {
        private readonly PessoaService _pessoaService;
        private readonly AgendamentoService _agendamentoService;

        public HomeController(PessoaService pessoaService, AgendamentoService agendamentoService)
        {
            _pessoaService = pessoaService;
            _agendamentoService = agendamentoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SimpleSearch(DateTime? data)
        {
            if (!data.HasValue)
            {
                data = new DateTime(DateTime.Now.Year, 1, 1);
            }
            ViewData["data"] = data.Value.ToString("yyyy-MM");
            var result = _agendamentoService.FindByDate(data);
            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
