using Lb3_CSharp.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3_CSharp.Errors
{
    internal class NeedsMastersToHireException : NeedsEmployeeToHireException
    {
        public int QuantityOfMastersToHire { get; private set; }
        public NeedsMastersToHireException(string message, int quantityOfMastersToHire)
            : base(message)
        {
            QuantityOfMastersToHire = quantityOfMastersToHire;
        }
    }
}
