using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Vendeur
    {
        public int codeVen { get; }
        public string? nomVend { get; set; }
        public string? psudoVend { get; set; }

        public string? passVend { get; set; }
        public int phoneVend { get; set; }
        public string? addVend { get; set; }

    }
}
