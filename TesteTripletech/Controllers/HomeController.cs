﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteTripletech.Models;
using TesteTripletech.Services;
using System.IO;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.Formatters.Internal;

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

        public IActionResult Adicionar()
        {
            string[] lines = System.IO.File.ReadAllLines("AdicionarAgendamento.csv");
            int pessoas = int.Parse(lines[0]);
            string[] IdsTexto = new string[pessoas];
            IdsTexto = lines[1].Split(',');
            int[] Ids = new int[pessoas];
            int i = 0;
            foreach(string x in IdsTexto)
            {
                Ids[i] = int.Parse(IdsTexto[i]);
                i++;
            }
            string[] dataTexto = lines[2].Split(',');
            DateTime dataInicio = DateTime.Parse(dataTexto[0]);
            DateTime dataFim = DateTime.Parse(dataTexto[1]);

            Boolean result = _agendamentoService.Adicionar(Ids,dataInicio,dataFim);
            string query;
            if (result){
                query = "INSERT INTO agendamento (local, datainicio, datafim) " +
                    "VALUES('null', '2020-06-30 12:00:00', '2020-06-30 22:00:00');" +

                    "   INSERT INTO pessoaagendamento (pessoaid, agendamentoid) " +
                    "SELECT '1', agendamentoid" +
                    "FROM agendamento" +
                    "WHERE local='null',datainicio='2020-06-30 12:00:00',datafim='2020-06-30 22:00:00'" +

                    "   INSERT INTO pessoaagendamento (pessoaid, agendamentoid) " +
                    "SELECT '5', agendamentoid" +
                    "FROM agendamento" +
                    "WHERE local='null',datainicio='2020-06-30 12:00:00',datafim='2020-06-30 22:00:00'" +

                    "   INSERT INTO pessoaagendamento (pessoaid, agendamentoid) " +
                    "SELECT '8', agendamentoid" +
                    "FROM agendamento" +
                    "WHERE local='null',datainicio='2020-06-30 12:00:00',datafim='2020-06-30 22:00:00'";
            }
            else
            {
                query = "Conflito de agendamentos";
            }
            ViewData["Menssagem"] = query;
            return View();
        }

        public IActionResult Atualizar()
        {
            string[] lines = System.IO.File.ReadAllLines("AtualizarAgendamento.csv");
            int Id = int.Parse(lines[0]);
            string[] dataTexto = lines[1].Split(',');
            DateTime dataInicio = DateTime.Parse(dataTexto[0]);
            DateTime dataFim = DateTime.Parse(dataTexto[1]);

            Boolean result = _agendamentoService.Atualizar(Id, dataInicio, dataFim);
            string query;
            if (result)
            {
                query = "UPDATE agendamento" +
                    "   SET datainicio = 2020-05-30 08:00:00, datafim = 2020-05-30 12:00:00" +
                    "   WHERE id = 93";
            }
            else
            {
                query = "Conflito de agendamentos";
            }
            ViewData["Menssagem"] = query;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
