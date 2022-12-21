using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3_CSharp.Errors
{
    public abstract class NeedsEmployeeToHireException : ArgumentException
    {
        public NeedsEmployeeToHireException(string message)
            : base(message)
        { }
    }
}
