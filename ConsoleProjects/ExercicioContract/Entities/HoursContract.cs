using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContract.Entities
{
    internal class HoursContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHurs { get; set; }
        public int Hours { get; set; }

        public HoursContract(DateTime date, double valuePerHurs, int hours)
        {
            Date = date;
            ValuePerHurs = valuePerHurs;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHurs * Hours;
        }


    }
}
