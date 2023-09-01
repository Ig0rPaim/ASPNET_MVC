using C_2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Id.ToString());
            sb.Append(',');
            sb.Append(Moment.ToString());
            sb.Append(",");
            sb.Append(Status.ToString());
            return sb.ToString();
        }

    }
}
