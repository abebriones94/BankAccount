using MySuperBank;

internal class Program
{
    private static void Main(string[] args)
    {
        // Calling the constructor method 
        var account = new BankAccount("Kendra", 10000);

        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}$");

        account.MakeWithdrawal(120, DateTime.Now, "Hammock");
        Console.WriteLine($"{account.Balance}$ is your new balance");

        account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
        Console.WriteLine($"{ account.Balance}$");

        Console.WriteLine();

        Console.WriteLine(account.GetAccountHistory());


        // CTRL C + K will comment out multiple lines of code 

        //// Tests for a negative balance
        //try
        //{
        //    account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
        //}
        //catch (InvalidOperationException e)
        //{
        //    Console.WriteLine("Exception caught trying to overdraw");
        //    Console.WriteLine(e.ToString());
        //}

        //// Tests that the initial balance must be positive 
        //try
        //{
        //    var invalidAccount = new BankAccount("invalid", -55);
        //}
        //catch (ArgumentOutOfRangeException e)
        //{
        //    Console.WriteLine("Exception caught creating account with negative balance");


        }
    }
