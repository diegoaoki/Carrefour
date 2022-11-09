using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Carrefour.Models
{
    public class VisaoContabilModels
    {
        public List<VisaoContabilItem> listVisaoItem { get; set; }

    }


    public class VisaoContabilItem
    {
        [Display(Name = "Conta Contábil")]
        public String contaContabil { get; set; }

        [Display(Name = "Descrição")]
        public String descricao { get; set; }
        [Display(Name = "Descrição")]
        public String nivel1 { get; set; }
        [Display(Name = "Descrição")]
        public String nivel2 { get; set; }
        [Display(Name = "Descrição")]
        public String nivel3 { get; set; }
        [Display(Name = "Descrição")]
        public String nivel4 { get; set; }
        [Display(Name = "Descrição")]
        public String nivel5 { get; set; }

    }
}