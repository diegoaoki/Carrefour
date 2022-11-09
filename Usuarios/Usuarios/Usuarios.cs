using Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Usuarios
{
    public class Usuarios
    {

        UsuariosDataContext dataContext = new UsuariosDataContext();


        /// <summary>
        /// GET LIST OF MENUS
        /// </summary>
        /// <returns></returns>
        public DataTable getListOfMenus()
        {
            List<MENU> listMenu = (from i in dataContext.GetTable<MENU>()
                                   where i.INDICA_INATIVO == false
                                   orderby i.ORDEM
                                   select i).ToList();


            DataTable retorno = new DataTable();
            retorno.Columns.Add("NOME_MENU");
            retorno.Columns.Add("PROCEDURE");
            retorno.Columns.Add("CONTROLLER");

            foreach (var item in listMenu)
            {

                DataRow newItem = retorno.NewRow();
                newItem[0] = item.NOME_REPORT;
                newItem[1] = item.PROCEDURE;
                newItem[2] = item.CONTROLLER;

                retorno.Rows.Add(newItem);

            }

            return retorno;

        }

    }
}
