using Exercicio_1_Interface.Services;

namespace Exercicio_1_Interface.Services
{
    class PaypallService : IOnlinePaymentService
    {
        private const double feePerPayement = 0.02;
        private const double simpleInterest = 0.01;

        public double Interest (double amount, int months)
        {
            return amount * simpleInterest * months;
        }

        public double PaymentFee (double amount)
        {
            return amount * feePerPayement;
        }
    }
}
