using Lb3_CSharp.Errors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Lb3_CSharp.Models.HR
{
    public class FactoryHR : IFactoryHR
    {
        private const int SlavesPerMaster = 10;
        private Dictionary<string, Slave> _slaves;
        private Dictionary<string, Master> _masters;
        public FactoryHR(decimal incomePerSlave, decimal incomePerMaster)
        {
            IncomePerSlave = incomePerSlave;
            IncomePerMaster = incomePerMaster;
            int qunatOfMastersToHire = FindOutQuantityOfMastersToHire(), quantOfSlavesToHire = FindOutQuantityOfSlavesToHire();
            if (qunatOfMastersToHire != 0)
            {
                throw new NeedsMastersToHireException("Quantity of masters is not enough", qunatOfMastersToHire);
            }

            if (quantOfSlavesToHire != 0)
            {
                throw new NeedsSlavesToHireException("Quantity of salves is not enough", quantOfSlavesToHire);
            }
        }

        [JsonConstructor]
        public FactoryHR(Dictionary<string, Slave> employees, Dictionary<string, Master> masters, decimal incomePerSlave, decimal incomePerMaster)
        {
            if (masters == null || employees == null)
            {
                throw new ArgumentNullException("Dictionaries are referenced to null");
            }

            Employees = employees;
            Masters = masters;
            var quantOfMastersToHire = FindOutQuantityOfMastersToHire();
            if (quantOfMastersToHire != 0)
            {
                throw new NeedsMastersToHireException("Not enough masters", quantOfMastersToHire);
            }

            var quantOfSlavesToHire = FindOutQuantityOfSlavesToHire();
            if (quantOfSlavesToHire != 0)
            {
                throw new NeedsSlavesToHireException("Not enough slaves", quantOfSlavesToHire);
            }

            IncomePerSlave=incomePerSlave;
            IncomePerMaster=incomePerMaster;
        }

        public FactoryHR(IFactoryHR other)
        {

            Employees = other.Employees;
            Masters = other.Masters;
            IncomePerSlave = other.IncomePerSlave;
            IncomePerMaster = other.IncomePerMaster;
        }
        public Dictionary<string, Slave> Employees { get => _slaves; private set => _slaves = value;  }
        public Dictionary<string, Master> Masters { get => _masters; private set => _masters = value; }
        public decimal IncomePerSlave { get; private set; }
        public decimal IncomePerMaster { get; private set; }
        public int QuantityOfMasters { get => _masters.Count;  }
        public int QuantityOfSlaves { get => _slaves.Count; }

        public void AddMaster(Master master)
        {
            if (FindOutQuantityOfMastersToHire() > 0)
            {
                _masters.Add(master.TIN, master);
            }
        }

        public void AddSlave(Slave slave)
        {
            if (FindOutQuantityOfSlavesToHire() > 0)
            {
                _slaves.Add(slave.TIN, slave);
            }
        }

        public bool RemoveMaster(string tin)
        {
            if (QuantityOfMasters <= 0)
            {
                return false;
            }

            return _masters.Remove(tin);
        }

        public bool RemoveSlave(string tin)
        {
            if (QuantityOfSlaves <= 0)
            {
                return false;
            }

            return _slaves.Remove(tin);
        }

        private int FindOutQuantityOfSlavesToHire()
        {
            if (QuantityOfSlaves == 0)
            {
                return SlavesPerMaster;
            }

            if (QuantityOfMasters == 0)
            {
                throw new NeedsMastersToHireException("There is no masters to lead slaves!", (int)Math.Ceiling(QuantityOfSlaves*0.1));
            }
            int needsSlaves = QuantityOfMasters * SlavesPerMaster - QuantityOfSlaves;
            if (needsSlaves > 0)
            {
                throw new NeedsSlavesToHireException("Needs slaves to hire!", needsSlaves * -1);
            }
            return needsSlaves;
        }
        private int FindOutQuantityOfMastersToHire()
        {
            if (QuantityOfSlaves == 0)
            {
                throw new NeedsSlavesToHireException("There is no slaves to work!", SlavesPerMaster);
            }

            if (QuantityOfMasters == 0)
            {
                return (int)Math.Ceiling(QuantityOfSlaves*0.1);
            }

            int needsMasters = (int)Math.Ceiling((double)(QuantityOfSlaves - QuantityOfMasters * SlavesPerMaster) / SlavesPerMaster);
            if (needsMasters < 0)
            {
                throw new NeedsSlavesToHireException("Needs slaves to hire!", needsMasters * -1);
            }

            return needsMasters;
        }
    }
}
