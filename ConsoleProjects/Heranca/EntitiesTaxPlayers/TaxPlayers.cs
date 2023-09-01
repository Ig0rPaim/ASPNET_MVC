using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.EntitiesTaxPlayers
{
    internal abstract class TaxPlayers
    {
        public string? Name { get; private set; }
        public double AnualIncome { get; private set; }

        protected TaxPlayers(string? name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes(double AnualIncome);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}: $ {Taxes(AnualIncome)}");
            return sb.ToString();
        }
    }
}
