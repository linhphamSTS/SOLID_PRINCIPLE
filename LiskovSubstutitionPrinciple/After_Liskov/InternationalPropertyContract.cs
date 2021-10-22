using System;

namespace LiskovSubstutitionPrinciple.After_Liskov
{
    internal class InternationalPropertyContract : PropertyContract
    {
        public InternationalPropertyContract(Buyer buyer, string contractName, DateTime createdDate, DateTime validDate)
            : base(buyer, contractName, createdDate, validDate) { }

        public virtual void CreateRentContract()
        {
            Console.WriteLine("Renting Contract created sucessull!.");
            Console.WriteLine($@"Buyer Information: Name: {Buyer.Name}, Phone: {Buyer.PhoneNumber}, Address: {Buyer.Address}");
        }
    }
}