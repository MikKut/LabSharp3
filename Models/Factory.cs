using System;
using System.Collections.Generic;
using System.Linq;
using Lb3_CSharp.Models.HR;
using Newtonsoft.Json;

namespace Lb3_CSharp.Models
{
    internal class Factory : IFactory, IComparable<IFactory>
    {
        private List<Workshop> _workshops;
        [JsonConstructor]
        public Factory(string name, IEnumerable<Workshop> workshops, FactoryHR factoryHR)
        {
            if (string.IsNullOrEmpty(name) || factoryHR == null || workshops == null)
            {
                throw new ArgumentNullException("Some of the arguments in factory is null");
            }

            Name = name;
            Workshops = workshops.ToList();
            FactoryHR = factoryHR;
        }

        public Factory(IFactory factory)
        {
            Name = factory.Name;
            FactoryHR = factory.FactoryHR;
            _workshops = factory.Workshops;
        }

        public string Name { get; private set; }
        public List<Workshop> Workshops { get => _workshops; private set => _workshops = value; }

        public int QuantityOfWorkshops { get => _workshops.Count; }

        public FactoryHR FactoryHR { get; private set; }

        public int CompareTo(IFactory other)
        {
            if (Name == other.Name && Workshops == other.Workshops && FactoryHR == other.FactoryHR)
            {
                return 0;
            }

            return Name.CompareTo(other.Name) >= 0 ? 1 : -1;            
        }
    }
}
