using Carrefour.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carrefour.Controllers
{
    public class FaturamentoController : Controller
    {
        // GET: Faturamento
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ConsultaFaturamento()
        {

            FaturamentoModels model = new FaturamentoModels();


            if (model.faturamentoDiario == null)
            {
                model.faturamentoDiario = new List<FaturamentoItem>();
            }

            if (model.faturamentoMensal == null)
            {
                model.faturamentoMensal = new List<FaturamentoItem>();
            }

            Faturamento.Faturamento faturamento = new Faturamento.Faturamento();
            
            model.faturamentoDiario = convertDataTableToList(faturamento.getFaturamentoDiario());
            model.faturamentoMensal = convertDataTableToList(faturamento.getFaturamentoMensal());


            return View(model);
        }


        private List<FaturamentoItem> convertDataTableToList(DataTable origem)
        {

            List<FaturamentoItem> retorno = new List<FaturamentoItem>();


            for (int i = 0; i < origem.Rows.Count; i++)
            {

                FaturamentoItem newItem = new FaturamentoItem();
                newItem.grupoProduto = (String)origem.Rows[i][0];
                newItem.valor = (Decimal)origem.Rows[i][1];

                retorno.Add(newItem);


            }
            return retorno;
        }



    }
}