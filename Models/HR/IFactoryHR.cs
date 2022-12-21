using System.Collections.Generic;

namespace Lb3_CSharp.Models.HR
{
    public interface IFactoryHR
    {
        Dictionary<string, Slave> Employees { get; }
        Dictionary<string, Master> Masters { get;  }
        decimal IncomePerMaster { get; }
        decimal IncomePerSlave { get; }
        int QuantityOfMasters { get; }
        int QuantityOfSlaves { get; }
        void AddMaster(Master master);
        void AddSlave(Slave slave);
        bool RemoveMaster(string tin);
        bool RemoveSlave(string tin);
    }
}