namespace Lb3_CSharp.Models
{
    public interface IWorkshop
    {
        int NumberOfDetailsPerEmloyee { get; }
        int NumberOfDetailsPerMaster { get; }
        decimal PrimeCost { get; }
        decimal SellingCost { get; }
        int ID { get; }
        int NumberOfWorkplaces { get; }
        int CurrentNumberOfEmployees { get; }
        int CurrentNumberOfMasters { get; }
        int MaxCapacity { get; }

    }
}