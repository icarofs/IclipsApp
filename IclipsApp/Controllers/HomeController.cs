using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IclipsApp.Model.Context;
using IclipsApp.Model.Entities;

namespace IclipsApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Contador Menu da Esquerda
            using (IclipsAppContext Banco = new IclipsAppContext())
            {
                ViewBag.EmAndamentoQtd = Banco.Pessoa.Where(a => a.Situacao == 0).Count();
                ViewBag.AtrasadasQtd = Banco.Pessoa.Where(a => a.Situacao == 1).Count();
                ViewBag.ListaPessoasEmAndamento = Banco.Pessoa.Where(a => a.Situacao == 0).ToList();
                ViewBag.ListaPessoasAtrasadas = Banco.Pessoa.Where(a => a.Situacao == 1).ToList();
                ViewBag.ListaPessoasGeral = Banco.Pessoa.ToList();
                ViewBag.ListaPessoasOrdenadas = Banco.Pessoa.OrderBy(a => a.Nome).ToList();
            }

                return View();
        }

    }
}