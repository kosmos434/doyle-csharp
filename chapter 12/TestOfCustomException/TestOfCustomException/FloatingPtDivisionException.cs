using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOfCustomException
{
    class FloatingPtDivisionException: System.ApplicationException
    {
        public FloatingPtDivisionException(string exceptionType)
            :base (exceptionType)
        {
            // empty body ctor
        }
    }
}
