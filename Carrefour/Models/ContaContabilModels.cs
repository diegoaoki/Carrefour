using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carrefour.Models
{
    public class ContaContabilModels
    {

        public List<ContaContabilItem> listContaContabil { get; set; }

    }

    public class ContaContabilItem
    {
        [Display(Name ="Conta Contábil")]
        public String contaContabil { get; set; }

        [Display(Name ="Descrição")]
        public String descricao { get; set; }

        [Display(Name ="Nível")]
        public String nivel { get; set; }


    }

    

}