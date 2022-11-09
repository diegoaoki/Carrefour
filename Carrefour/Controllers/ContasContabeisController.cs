using Carrefour.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carrefour.Controllers
{
    public class ContasContabeisController : Controller
    {
        // GET: ContasContabeis
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ConsultaConta()
        {

            ContaContabilModels model = new ContaContabilModels();

            if (model.listContaContabil == null)
            {
                model.listContaContabil = new List<ContaContabilItem>();
            }



            DataTable consultaConta = new Contabilidade.ContaContabeis.ContaContabeis().getContaContabeis();
            // CLASSIFICACAO - 0
            // DESCRICAO - 1
            // NIVEL1 - 2
            // NIVEL2 - 3
            // NIVEL3 - 4
            // NIVEL4 - 5
            // NIVEL5 - 6

            for (int i = 0; i < consultaConta.Rows.Count; i++)
            {
                ContaContabilItem newItem = new ContaContabilItem();

                newItem.contaContabil = (String)consultaConta.Rows[i][0];
                newItem.descricao = (String)consultaConta.Rows[i][1];

                model.listContaContabil.Add(newItem);
            }


            return View(model);


        }


        public ActionResult ConsultaVisaoContabil()
        {
            VisaoContabilModels model = new VisaoContabilModels();


            if (model.listVisaoItem == null)
            {
                model.listVisaoItem = new List<VisaoContabilItem>();
            }



            DataTable consultaConta = new Contabilidade.ContaContabeis.ContaContabeis().getContaContabeis();
            // CLASSIFICACAO - 0
            // DESCRICAO - 1
            // NIVEL1 - 2
            // NIVEL2 - 3
            // NIVEL3 - 4
            // NIVEL4 - 5
            // NIVEL5 - 6

            for (int i = 0; i < consultaConta.Rows.Count; i++)
            {
                VisaoContabilItem newItem = new VisaoContabilItem();

                newItem.contaContabil = (String)consultaConta.Rows[i][0];
                newItem.descricao = (String)consultaConta.Rows[i][1];

                if (consultaConta.Rows[i][2] == DBNull.Value)
                {
                    newItem.nivel1 = "";
                }
                else
                {
                    newItem.nivel1 = (String)consultaConta.Rows[i][2];
                }

                if (consultaConta.Rows[i][3] == DBNull.Value)
                {
                    newItem.nivel2 = "";
                }
                else
                {
                    newItem.nivel2 = (String)consultaConta.Rows[i][3];
                }

                if (consultaConta.Rows[i][4] == DBNull.Value)
                {
                    newItem.nivel3 = "";
                }
                else
                {
                    newItem.nivel3 = (String)consultaConta.Rows[i][4];
                }

                if (consultaConta.Rows[i][5] == DBNull.Value)
                {
                    newItem.nivel4 = "";
                }
                else
                {
                    newItem.nivel4 = (String)consultaConta.Rows[i][5];
                }

                if (consultaConta.Rows[i][6] == DBNull.Value)
                {
                    newItem.nivel5 = "";
                }
                else
                {
                    newItem.nivel5 = (String)consultaConta.Rows[i][6];
                }


                model.listVisaoItem.Add(newItem);
            }


            return View(model);

        }




        public ActionResult ConsultaBalancete(BalanceteModels model)
        {
            if (model.listBalancete == null)
            {
                model.listBalancete = new List<balanceteItem>();
            }

            if (model.dataInicial.Year < 1900)
            {
                return View(model);
            }

            if (model.dataFinal.Year > 2900)
            {
                return View(model);
            }



            DataTable consulta = new Contabilidade.Balancete().getBalancete(model.dataInicial, model.dataFinal, model.indicaContasMovimento);
            // VISAO_CONTABIL - 0
            // CLASSIFICACAO - 1
            // DESCR_CONTA - 2
            // NIVEL_CONTA - 3
            // NIVEL1 - 4
            // NIVEL2 - 5
            // NIVEL3 - 6
            // NIVEL4 - 7
            // NIVEL5 - 8
            // SALDO - 9
            // DEBITO - 10
            // CREDITO - 11
            // SALDO_FINAL - 12


            for (int i = 0; i < consulta.Rows.Count; i++)
            {

                balanceteItem newItem = new balanceteItem();
                newItem.classificacao = (String)consulta.Rows[i][1] + " - " + (String)consulta.Rows[i][2];
                newItem.saldoFinal = Convert.ToDecimal(consulta.Rows[i][12]);
                newItem.credito = Convert.ToDecimal(consulta.Rows[i][11]);
                newItem.debito = Convert.ToDecimal(consulta.Rows[i][10]);
                newItem.saldoInicial = Convert.ToDecimal(consulta.Rows[i][9]);

                model.listBalancete.Add(newItem);
            }



            return View(model);
        }

    }
}