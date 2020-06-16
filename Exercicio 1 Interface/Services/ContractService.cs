﻿using System;
using Exercicio_1_Interface.Entities;
using Exercicio_1_Interface.Services;


namespace Exercicio_1_Interface.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void processContract (Contract contract, int months)
        {
            double initialValue = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime duoDate = contract.Date.AddMonths(i);
                initialValue = initialValue +  _onlinePaymentService.Interest(initialValue, i);
                double updatedValue = initialValue + _onlinePaymentService.PaymentFee(initialValue);
                contract.addContract(new Installment(duoDate, updatedValue));
            }
        }
    }
}
