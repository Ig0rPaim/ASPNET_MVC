using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities2
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; protected set; }
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price += CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(TotalPrice());
            sb.Append($" (customs fee: $ {CustomsFee})");
            return sb.ToString();
        }



    }
}
