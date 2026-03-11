using Taxpayer.Entities.Enums;
using Taxpayer.Entities;

namespace Taxpayer.Entities
{
    internal class IndividualTaxpayer : Taxpayer
    {
        public double HealthExpenditures { get; set; }

        public IndividualTaxpayer() { }

        public IndividualTaxpayer(double healthExpenditures, string name, double annualIncome) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax;
            if (AnnualIncome < 20000.00)
            {
                tax = AnnualIncome * 0.15;
            }
            else
            {
                tax = AnnualIncome * 0.25;
            }
            tax -= HealthExpenditures * 0.5;
            return tax < 0 ? 0 : tax;  // Ensure that tax cannot be negative and return 0 if it is 
        }
    }
}
