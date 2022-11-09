using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carrefour.Models
{
    public class BalanceteModels
    {

        [Required]
        [Display(Name ="Data Inicial")]
        public DateTime dataInicial { get; set; }

        [Required]
        [Display(Name = "Final")]
        public DateTime dataFinal { get; set; }


        
        [Display(Name = "Somente Contas com Movimento")]
        public Boolean indicaContasMovimento { get; set; }


        public List<balanceteItem> listBalancete { get; set; }

    }


    public class balanceteItem
    {

        [Display(Name = "Conta Contábil")]
        public String classificacao { get; set; }
        [Display(Name = "Descrição")]
        public String descricao { get; set; }
        [Display(Name = "Saldo Anterior")]
        public Decimal saldoAnterior { get; set; }
        [Display(Name = "Debito")]
        public Decimal debito { get; set; }
        [Display(Name = "Credito")]
        public Decimal credito { get; set; }
        [Display(Name = "Saldo Final")]
        public Decimal saldoFinal { get; set; }


        [Display(Name = "Saldo Inicial")]
        public Decimal saldoInicial { get; set; }

    }

}