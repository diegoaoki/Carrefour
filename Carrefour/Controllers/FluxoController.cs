using Carrefour.Models;
using Fluxo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carrefour.Controllers
{
    public class FluxoController : Controller
    {
        // GET: Fluxo
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ConsultaFluxo(FluxoModels model)
        {

            if (model.listItem  == null)
            {
                model.listItem = new List<FluxoItem>();
            }

            if (model.dataInicial.Year < 1900)
            {
                return View(model);
            }

            if (model.dataFinal.Year > 2900)
            {
                return View(model);
            }


            DataTable consulta = new Fluxo.Fluxo().getListOfFluxCaixa(model.dataInicial, model.dataFinal);
            // DATA_LANCAMENTO - 0
            // DESCRICAO - 1
            // DEBITO - 2
            // CREDITO - 3
            // SALDO - 4

            for (int i = 0; i < consulta.Rows.Count; i++)
            {
                FluxoItem newItem = new FluxoItem();
                newItem.dataLancamneto = (DateTime)consulta.Rows[i][0];
                newItem.descricao = (String)consulta.Rows[i][1];
                newItem.debito = (Decimal)consulta.Rows[i][2];
                newItem.credito = (Decimal)consulta.Rows[i][3];
                newItem.saldo = (Decimal)consulta.Rows[i][4];

                model.listItem.Add(newItem);
            }


            return View(model);
        }
    }
}