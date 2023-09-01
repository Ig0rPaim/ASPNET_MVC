using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions.Exeptions
{
    internal class NoBalanceExeption : ApplicationException
    {
        public NoBalanceExeption(string? message) : base(message)
        {
        }
    }
}
