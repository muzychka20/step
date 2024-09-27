using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.Exceptions
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }
}
