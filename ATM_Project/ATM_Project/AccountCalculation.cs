using System;

namespace Classes
{
    public class AccountCalculations //Will do calculations for withdrawels and deposits
    {

        string TestTwo = "Calc connected";

        private ulong _currentFunds;

        public string GetInformation()
        {
            return TestTwo;

        }
        public ulong Funds()
        {
            return _currentFunds;
        }
        
        internal void Withdraw(uint Balance)
        {
            _currentFunds -= Balance;
        }
        public void Withdraw(ushort Balance)
        {
            _currentFunds -= Balance;
        }




    }
}