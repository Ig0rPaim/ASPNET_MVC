using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.EntitiesTaxPlayers
{
    internal class Individual : TaxPlayers
    {
        public double HealthExependitures { get; protected set; }

        public Individual(string? name, double anualIncome, double healthExependitures) : base(name, anualIncome)
        {
            HealthExependitures = healthExependitures;
        }

        public override double Taxes(double AnualIncome)
        {
            double Sub = (HealthExependitures > 0) ? HealthExependitures / 2 : 0;
            if (AnualIncome < 2000) 
            { 
                return (AnualIncome * 0.15) - Sub; 
            }
            else 
            { 
                return (AnualIncome * 0.25) - Sub; 
            }
        }
    }
}
