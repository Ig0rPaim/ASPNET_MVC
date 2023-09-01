using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.EntitiesTaxPlayers
{
    internal class Company : TaxPlayers
    {
        public int NumberOfEmployers { get; protected set; }

        public Company(string? name, double anualIncome, int numberOfEmployers) : base(name, anualIncome)
        {
            NumberOfEmployers = numberOfEmployers;
        }

        public override double Taxes(double AnualIncome)
        {
            if (NumberOfEmployers > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.15;
            }
        }
    }
}
