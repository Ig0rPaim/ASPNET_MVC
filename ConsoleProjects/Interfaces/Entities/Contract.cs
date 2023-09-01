using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }

        public Contract(int number, DateTime date)
        {
            Number = number;
            Date = date;
        }

        public double TotalValue
        {
            get { return  } 
        }

    }
}
