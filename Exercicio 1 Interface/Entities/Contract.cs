using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_1_Interface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments = new List<Installment>(null);

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void addContract (Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
