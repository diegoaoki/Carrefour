using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carrefour.Models
{
    public class MenuModels
    {

        public List<MenuItem> listItem { get; set; }



        public class MenuItem
        {

            public String nome { get; set; }
            public String controller { get; set; }
            public String procedure { get; set; }

        }
    }
}