using Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidade
{
    public class Balancete
    {

        ContabilidadeDataContext dataContext = new ContabilidadeDataContext();


        /// <summary>
        /// GET BALANCETE
        /// </summary>
        /// <param name="dataInicial">Data Inicial</param>
        /// <param name="dataFinal">Data Final</param>
        /// <param name="hasMoviment">Indicate if show account with moviment only</param>
        /// <returns></returns>
        public DataTable getBalancete(DateTime dataInicial, DateTime dataFinal, Boolean hasMoviment)
        {


            dataContext.PROC_GERA_BALANCETE(dataInicial, dataFinal, hasMoviment);

            List<CTB_BALANCETE> listBalancete = (from i in dataContext.GetTable<CTB_BALANCETE>()
                                                 select i).ToList();


            DataTable retorno = new DataTable();
            retorno.Columns.Add("VISAO_CONTABIL");
            retorno.Columns.Add("CLASSIFICACAO");
            retorno.Columns.Add("DESCR_CONTA");
            retorno.Columns.Add("NIVEL_CONTA");
            retorno.Columns.Add("NIVEL1");
            retorno.Columns.Add("NIVEL2");
            retorno.Columns.Add("NIVEL3");
            retorno.Columns.Add("NIVEL4");
            retorno.Columns.Add("NIVEL5");
            retorno.Columns.Add("SALDO", typeof(Decimal));
            retorno.Columns.Add("DEBITO", typeof(Decimal));
            retorno.Columns.Add("CREDITO", typeof(Decimal));
            retorno.Columns.Add("SALDO_FINAL, typeof(Decimal)");


            foreach (var item in listBalancete)
            {

                DataRow newRow = retorno.NewRow();
                newRow[0] = item.VISAO_CONTABIL;
                newRow[1] = item.CLASSIFICACAO;
                newRow[2] = item.DESCR_CONTA;
                newRow[3] = item.NIVEL_CONTA;
                newRow[4] = item.NIVEL1;
                newRow[5] = item.NIVEL2;
                newRow[6] = item.NIVEL3;
                newRow[7] = item.NIVEL4;
                newRow[8] = item.NIVEL5;
                newRow[9] = item.SALDO;
                newRow[10] = item.DEBITO;
                newRow[11] = item.CREDITO;
                newRow[12] = item.SALDO_FINAL;

                retorno.Rows.Add(newRow);
            }

            return retorno;
        }

    }
}