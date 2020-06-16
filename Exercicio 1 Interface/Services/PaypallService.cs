using Exercicio_1_Interface.Services;

namespace Exercicio_1_Interface.Services
{
    class PaypallService : IOnlinePaymentService
    {
        private const double simpleInterest = 0.01;
        private const double feePercentage = 0.02;

        public double Interest (double amount, int months)
        {
            return amount * simpleInterest * months;
        }

        public double PaymentFee (double amount)
        {
            return amount * 0.02;
        }
    }
}
