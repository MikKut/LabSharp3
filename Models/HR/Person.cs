using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3_CSharp.Models.HR
{
    public abstract class Person
    {
        private int _wokshopID;
        private string
            _name,
            _TIN;
        public Person(int wokshopID, string name, string tin)
        {
            WokshopID = wokshopID;
            Name = name;
            TIN = tin;
        }

        public int WokshopID
        {
            get => _wokshopID;
            protected set =>
                _wokshopID = value;
        }
        public string Name
        {
            get => _name;
            protected set => _name = value;
        }
        public string TIN
        {
            get => _TIN;
            set =>
                _TIN =
                value.Length == 10 && long.TryParse(value, out _)
                ? value
                : throw new ArgumentException("Invalid TIN");
        }
        public abstract decimal Salary { get; }
    }
}
