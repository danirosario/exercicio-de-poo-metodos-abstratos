using System;
using System.Globalization;
using TaxpayerProject.Entities;
//using Taxpayer.Entities.Enums;
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
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Health  expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxpayers.Add(new IndividualTaxpayer(healthExpenditures, name, anualIncome));


                }
            }
        }
    }
}

