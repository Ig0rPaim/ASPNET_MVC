using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    interface IPaypal
    {
        public double PaymentFee(double Amount);

        public double Interest(double Amount, int Months);
    }
}
