using System;

namespace LiskovSubstutitionPrinciple.After_Liskov
{
    internal class ForeignerContract : InternationalPropertyContract
    {
        public ForeignerContract(Buyer buyer, string contractName, DateTime createdDate, DateTime validDate) :
            base(buyer, contractName, createdDate, validDate)
        { }

        public override void CreateRentContract()
        {
            base.CreateRentContract();
            Console.WriteLine("Renting time is 50 years");
            Console.WriteLine("Tax for Remote Area People is 25% / contract");
        }
    }
}