using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities2
{
    internal class UsedProduct : Product
    {
        public DateTime Date { get; protected set; }
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (used) ");
            sb.Append(" $ ");
            sb.Append(Price);
            sb.Append($" (Manufacture date: {Date})");
            return sb.ToString();
        }
    }
}
