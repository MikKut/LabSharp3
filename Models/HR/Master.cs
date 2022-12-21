using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3_CSharp.Models.HR
{
    public class Master : Person
    {
        private int _quantityOfCourses;
        public Master(int wokshopID, string name, string tin, int quantityOfCourses)
            : base(wokshopID, name, tin)
        {
            QuantityOfDoneCourses = quantityOfCourses;
        }
        public int QuantityOfDoneCourses
        {
            get => _quantityOfCourses;
            private set => _quantityOfCourses = value >= 0
                ? value
                : throw new ArgumentOutOfRangeException($"{nameof(QuantityOfDoneCourses)} is lower or equalt to 0");
        }
        public override decimal Salary => 40_000M; 
    }
}
