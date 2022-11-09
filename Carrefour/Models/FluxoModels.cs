using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carrefour.Models
{
    public class FluxoModels
    {

        [Display(Name ="Data Inicial")]
        public DateTime dataInicial { get; set; }

        [Display(Name ="Data Final")]
        public DateTime dataFinal { get; set; }

        public List<FluxoItem> listItem { get; set; }

    }

    public class FluxoItem
    {

        [Display(Name ="iD")]
        public int id { get; set; }

        [Display(Name ="Data Lançamento")]
        public DateTime dataLancamneto { get; set; }

        [Display(Name ="Descrição")]
        public String descricao { get; set; }

        [Display(Name ="Debito")]
        public Decimal debito { get; set; }

        [Display(Name ="Credito")]
        public Decimal credito { get; set; }

        [Display(Name ="Saldo")]
        public Decimal saldo { get; set; }

    }
}