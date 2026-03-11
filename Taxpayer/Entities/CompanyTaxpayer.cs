using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxpayer.Entities
{
    internal class CompanyTaxpayer : Taxpayer
    {
        public int NumberOfEmployees { get; set; }

        public CompanyTaxpayer() { }

        public CompanyTaxpayer(int numberOfEmployees, string name, double annualIncome) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax;
            if (NumberOfEmployees > 10)
            {
                tax = AnnualIncome * 0.14;
            }
            else
            {
                tax = AnnualIncome * 0.16;
            }
            return tax;

        }
    }
}
