using Lb3_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3_CSharp.Models
{
    public class Workshop : IWorkshop
    {
        private decimal _sellingCost;
        private int 
            _id,
            _numberOfWorkplaces,
            _currentNumberOfMasters,
            _currentNumberOfSlaves;

        public Workshop(decimal sellingCost, int id, int numberOfWorkplaces, int currentNumberOfMasters, int currentNumberOfEmployees, int maxCapacity)
        {
            NumberOfWorkplaces = numberOfWorkplaces;
            CurrentNumberOfMasters = currentNumberOfMasters;
            CurrentNumberOfEmployees = currentNumberOfEmployees;
            SellingCost = sellingCost;
            ID = id;
            MaxCapacity = maxCapacity;
        }

        public int NumberOfDetailsPerEmloyee { get => 10; }

        public int NumberOfDetailsPerMaster { get => 20; }

        public decimal PrimeCost { get => 34.2M; }

        public decimal SellingCost
        {
            get => _sellingCost;
            private set => _sellingCost = (value >= PrimeCost)
                ? value
                : throw new ArgumentOutOfRangeException(nameof(SellingCost));
        }

        public int ID
        {
            get => _id;
            private set => _id = (value > 0)
                ? value
                : throw new ArgumentException($"{nameof(ID)} is lower than 0");
        }

        public int NumberOfWorkplaces
        {
            get => _numberOfWorkplaces;
            private set => _numberOfWorkplaces = (value > 0)
                ? value
                : throw new ArgumentException($"{nameof(NumberOfWorkplaces)} is lower than 0");
        }

        public int CurrentNumberOfEmployees
        {
            get => _currentNumberOfSlaves;
            private set => _currentNumberOfSlaves = value;
        }

        public int CurrentNumberOfMasters 
        {
            get => _currentNumberOfMasters;
            private set => _currentNumberOfMasters = value;
        }

        public int MaxCapacity { get; set; }
    }
}
