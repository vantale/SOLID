
namespace ConsoleApp1.BadCode
{
    public class FlowByExceptions
    {
        public decimal Calculate(decimal amount, int partnerId)
        {
            if (amount < 0)
                throw new WrongAmountException();

            if(partnerId < 300)
                throw new WrongPartnerSelectedException();

            // retrieval from DB and calculations
            return 1234567.23m;
        }

        public void Execute()
        {
            try { 

            decimal recalculatedAmount = Calculate(123, 1);
            
            }
            catch(WrongAmountException)
            {
                // Call Method 1
            }
            catch (WrongPartnerSelectedException)
            {
                // Call Method 2
            }
        }

        public void Execute2()
        {
            try
            {
                decimal recalculatedAmount = Calculate(123, 1);

            }
            catch (BusinessException ex)
            {
                AnalyseBusinessRuleEx(ex);
            }
        }

        private void AnalyseBusinessRuleEx(BusinessException ex)
        {
            if(ex is WrongAmountException)
            {
                // Call Method 1
                return;
            }

            if (ex is WrongPartnerSelectedException)
            {
                // Call Method 2
                return;
            }
        }
    }

    public class WrongAmountException : BusinessException { }
    public class WrongPartnerSelectedException : BusinessException { }
    public class BusinessException : Exception { }
}
