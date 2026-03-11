using System;
using System.Globalization;
using TaxpayerProject.Entities;
using System.Collections.Generic;

namespace TaxpayerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> taxpayers = new List<Taxpayer>();

            Console.Write("Enter the number of taxpayers: ");

            int numberOfTaxpayers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTaxpayers; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data: ");
                Console.WriteLine("Individual or Company (i/c)?");
                char taxpayerType = char.Parse(Console.ReadLine());
                
                if (taxpayerType == 'i' || taxpayerType == 'I')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health  expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxpayers.Add(new IndividualTaxpayer(healthExpenditures, name, anualIncome));
                }
                else if (taxpayerType == 'c' || taxpayerType == 'C')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxpayers.Add(new CompanyTaxpayer(numberOfEmployees, name, anualIncome));
                }
                else 
                {
                    Console.WriteLine("Invalid taxpayer type. Please enter 'i' for Individual or 'c' for Company.");
                    i--; // Decrement i to repeat the iteration for valid input
                }
            }

            Console.WriteLine("\n TAXES PAID: ");
            foreach (Taxpayer taxpayer in taxpayers)
            {
               Console.WriteLine($"{taxpayer.Name}: $ {taxpayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            }
             double totalTaxes = 0.0;
            foreach (Taxpayer taxpayer in taxpayers)
            {
                totalTaxes += taxpayer.Tax();
            }
            Console.WriteLine("\n TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

