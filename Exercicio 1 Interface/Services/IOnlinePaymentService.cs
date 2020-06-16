using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_1_Interface.Services
{
    interface IOnlinePaymentService
    {
        public double Interest(double amount, int months);
        public double PaymentFee(double amount);

    }
}
