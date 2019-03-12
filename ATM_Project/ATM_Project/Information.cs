using System;

namespace Classes
{
    public class Information
    {
        string ClassTest = "This Worked";



        public string GetInformation()
        {
            return ClassTest;
        }

        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string AccountPIN { get; set; }
        public string Balance { get; set; }

        public string TestPIN = "1234";
        
        public static Information AccountCreation( string FName, string LName, string PIN, string UserFunds)//Creates the format for user variables
        {
            return new Information() { UserFirstName = FName, UserLastName = LName, AccountPIN = PIN, Balance = UserFunds};
        }
    }
}
