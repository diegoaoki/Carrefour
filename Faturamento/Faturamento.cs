using Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faturamento
{
    public  class Faturamento
    {

        FaturamentoDataContext dataContext = new FaturamentoDataContext();
        
        /// <summary>
        /// GET FATURAMENTO DIARIO
        /// </summary>
        /// <returns></returns>
        public DataTable getFaturamentoDiario()
        {

            List<FATURAMENTO_DIARIO> listFaturamento = (from i in dataContext.GetTable<FATURAMENTO_DIARIO>()
                                                        select i).ToList();


            DataTable retorno = new DataTable();
            retorno.Columns.Add("GRUPO_PRODUTO");
            retorno.Columns.Add("VALOR", typeof(Decimal));

            foreach (var item in listFaturamento)
            {
                DataRow newRow = retorno.NewRow();
                newRow[0] = item.GRUPO_PRODUTO;
                newRow[1] = item.VALOR;


                retorno.Rows.Add(newRow);


            }

            return retorno; 
        }


        /// <summary>
        /// GET FATURAMENTO MENSAL
        /// </summary>
        /// <returns></returns>
        public DataTable getFaturamentoMensal()
        {

            List<FATURAMENTO_MENSAL> listFaturamento = (from i in dataContext.GetTable<FATURAMENTO_MENSAL>()
                                                        select i).ToList();


            DataTable retorno = new DataTable();
            retorno.Columns.Add("GRUPO_PRODUTO");
            retorno.Columns.Add("VALOR", typeof(Decimal));

            foreach (var item in listFaturamento)
            {
                DataRow newRow = retorno.NewRow();
                newRow[0] = item.GRUPO_PRODUTO;
                newRow[1] = item.VALOR;


                retorno.Rows.Add(newRow);


            }

            return retorno;
        }
    }
}
