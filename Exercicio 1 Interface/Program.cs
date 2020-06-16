using System;
using System.Collections.Generic;
using Exercicio_1_Interface.Entities;
using Exercicio_1_Interface.Services;

namespace Exercicio_1_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypallService());
            contractService.processContract(contract, months);

            Console.WriteLine("Instalments: ");
            foreach (Installment item in contract.Installments)
            {
                Console.WriteLine(item);
            }

    




        }
    }
}
