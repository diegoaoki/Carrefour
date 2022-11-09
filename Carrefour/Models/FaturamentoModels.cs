using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carrefour.Models
{
    public class FaturamentoModels
    {

        public List<FaturamentoItem> faturamentoDiario { get; set; }
        public List<FaturamentoItem> faturamentoMensal { get; set; }

    }

    public class FaturamentoItem
    {
        [Display(Name ="Grupo Produto")]
        public String grupoProduto { get; set; }


        [Display(Name ="Valor")]
        public Decimal valor { get; set; }
    }
}