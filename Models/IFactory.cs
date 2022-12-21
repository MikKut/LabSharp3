using System.Collections.Generic;
using Lb3_CSharp.Models.HR;

namespace Lb3_CSharp.Models
{
    public interface IFactory
    {
        FactoryHR FactoryHR { get; }
        string Name { get; }
        int QuantityOfWorkshops { get; }
        List<Workshop> Workshops { get; }
    }
}