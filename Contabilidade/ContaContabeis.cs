using Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidade.ContaContabeis
{
    public class ContaContabeis
    {
        ContabilidadeDataContext dataContext = new ContabilidadeDataContext();


        /// <summary>
        /// GET CONTA CONTABIL LIST
        /// </summary>
        /// <returns></returns>
        public DataTable getContaContabeis()
        {

            List<CTB_VISAO_CONTABIL> listVisao = (from i in dataContext.GetTable<CTB_VISAO_CONTABIL>()
                                                  select i).ToList();


            DataTable retorno = new DataTable();
            retorno.Columns.Add("CLASSIFICACAO");
            retorno.Columns.Add("DESCRICAO");
            retorno.Columns.Add("NIVEL1");
            retorno.Columns.Add("NIVEL2");
            retorno.Columns.Add("NIVEL3");
            retorno.Columns.Add("NIVEL4");
            retorno.Columns.Add("NIVEL5");

            foreach (var item in listVisao)
            {
                DataRow newRow = retorno.NewRow();
                newRow[0] = item.CLASSIFICACAO;
                newRow[1] = item.DESCR_CONTA;
                newRow[2] = item.NIVEL1;
                newRow[3] = item.NIVEL2;
                newRow[4] = item.NIVEL3;
                newRow[5] = item.NIVEL4;
                newRow[6] = item.NIVEL5;

                retorno.Rows.Add(newRow);

            }


            return retorno;
        }


    }
}
