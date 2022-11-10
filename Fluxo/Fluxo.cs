using Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxo
{
    public class Fluxo
    {
        FluxoDataContext dataContext = new FluxoDataContext();


        /// <summary>
        /// GET LIST OF FLUXO DE CAIXA
        /// </summary>
        /// <param name="dataInicial">Data Inicial</param>
        /// <param name="dataFinal">Data Final</param>
        /// <returns></returns>
        public DataTable getListOfFluxCaixa(DateTime dataInicial, DateTime dataFinal)
        {


            List<CTB_FLUXO> listFluxo = (from i in dataContext.GetTable<CTB_FLUXO>()
                                         where i.DATA_LANCAMENTO >= dataInicial && i.DATA_LANCAMENTO <= dataFinal
                                         orderby i.DATA_LANCAMENTO
                                         select i).ToList();


            DataTable retorno = new DataTable();
            retorno.Columns.Add("DATA_LANCAMENTO", typeof(DateTime));
            retorno.Columns.Add("DESCRICAO");
            retorno.Columns.Add("DEBITO", typeof(Decimal));
            retorno.Columns.Add("CREDITO", typeof(Decimal));
            retorno.Columns.Add("SALDO", typeof(Decimal));


            foreach (var item in listFluxo)
            {
                DataRow newRow = retorno.NewRow();
                newRow[0] = item.DATA_LANCAMENTO;
                newRow[1] = item.DESCRICAO;
                newRow[2] = item.DEBITO;
                newRow[3] = item.CREDITO;
                newRow[4] = item.SALDO;

                retorno.Rows.Add(newRow);

            }
            return retorno;
        }

    }
}