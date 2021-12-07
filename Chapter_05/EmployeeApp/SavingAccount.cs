namespace EmployeeApp
{
    public class SavingAccount
    {
        // Instance-level data.
        public double currBalance;
        // A static point of data.
        private static double _currInterestRate = 0.04;
        // A static property.
        public static double InterestRate
        {
            get { return _currInterestRate; }
            set { _currInterestRate = value; }
        }
    }
}