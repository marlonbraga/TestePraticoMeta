namespace TestePraticoMeta.Domain
{
    public class Interest : Constants
    {
        public double __InterestRate__ { get; set; }

        public Interest()
        {
            __InterestRate__ = Constants.InterestRate;
        }
        
        public double GetInterestRate()
        {
            return InterestRate;
        }

        public double CalcInterest(double InitialValue, int Time)
        {
            var interest = Math.Pow(InitialValue * (1 + __InterestRate__), Time);
            interest = interest / Math.Pow(10,8);
            return Math.Round(interest,2);
        }
    }
}
