using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3_CSharp.Models.HR
{
    public class Slave : Person
    {
        public Slave(int wokshopID, string name, string tin, bool hasEducation)
            : base(wokshopID, name, tin)
        {
            HasEducation = hasEducation;
        }
        public override decimal Salary => 13_000M;
        public bool HasEducation { get; private set; }
    }
}
