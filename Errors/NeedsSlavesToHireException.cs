using Lb3_CSharp.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3_CSharp.Errors
{
    internal class NeedsSlavesToHireException : NeedsEmployeeToHireException
    {
        public int QuantityOfMastersToHire { get; private set; }
        public NeedsSlavesToHireException(string message, int quantityOfMastersToHire)
            : base(message)
        {
            QuantityOfMastersToHire = quantityOfMastersToHire;
        }
    }
}
 