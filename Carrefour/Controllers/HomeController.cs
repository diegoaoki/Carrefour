using Carrefour.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carrefour.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult menu()
        {

            MenuModels model = new MenuModels();


            if (model.listItem == null)
            {
                model.listItem = new List<MenuModels.MenuItem>();
            }


            DataTable getList = new Usuarios.Usuarios.Usuarios().getListOfMenus();
            // NOME - 0
            // PROCEDURE - 1
            // CONTROLLER - 2

            for (int i = 0; i < getList.Rows.Count; i++)
            {
                Models.MenuModels.MenuItem newItem = new Models.MenuModels.MenuItem();
                newItem.nome = (String)getList.Rows[i][0];
                newItem.procedure = (String)getList.Rows[i][1];
                newItem.controller = (String)getList.Rows[i][2];

                model.listItem.Add(newItem);
            }


            return PartialView(model);
        }
    }
}
