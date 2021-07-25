using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpMortageCalc.Models
{
    public class LoanPayment
    {
        public int Month { get; set; }

        /* 
            I think these filter how the following variables are displayed.
            Added in Bobby's solution
            [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
         */
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public decimal Payment { get; set; }

        /* 
            Added in Bobby's solution
            [DisplayFormat(DataFormatString = "{0:C0}")]
            Requires System.ComponentModel.DataAnnotations to compile. Make sure to add
            for these statements to run.
         */
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal MonthlyPrincipal { get; set; }
        public decimal MonthlyInterest { get; set; }
        public decimal TotalInterest { get; set; }
        public decimal Balance { get; set; }
    }
}
