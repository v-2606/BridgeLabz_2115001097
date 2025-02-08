//using System;

//class BankAccount
//{
//    public string AccountNumber { get; set; }
//    public double Balance { get; set; }

//    public BankAccount(string accountNumber, double balance)
//    {
//        AccountNumber = accountNumber;
//        Balance = balance;
//    }

//    public string GetAccountDetails()
//    {
//        return $"Account Number: {AccountNumber}, Balance: ${Balance}";
//    }
//}

//class SavingsAccount
//{
//    public BankAccount BankAccount { get; set; }
//    public double InterestRate { get; set; }

//    public SavingsAccount(BankAccount bankAccount, double interestRate)
//    {
//        BankAccount = bankAccount;
//        InterestRate = interestRate;
//    }

//    public void DisplayAccountType()
//    {
//        Console.WriteLine($"Account Type: Savings Account, Interest Rate: {InterestRate}%");
//    }

//    public string GetAccountDetails()
//    {
//        return $"{BankAccount.GetAccountDetails()}, Interest Rate: {InterestRate}%";
//    }
//}

//class CheckingAccount
//{
//    public BankAccount BankAccount { get; set; }
//    public double WithdrawalLimit { get; set; }

//    public CheckingAccount(BankAccount bankAccount, double withdrawalLimit)
//    {
//        BankAccount = bankAccount;
//        WithdrawalLimit = withdrawalLimit;
//    }

//    public void DisplayAccountType()
//    {
//        Console.WriteLine($"Account Type: Checking Account, Withdrawal Limit: ${WithdrawalLimit}");
//    }

//    public string GetAccountDetails()
//    {
//        return $"{BankAccount.GetAccountDetails()}, Withdrawal Limit: ${WithdrawalLimit}";
//    }
//}

//class FixedDepositAccount
//{
//    public BankAccount BankAccount { get; set; }
//    public int MaturityPeriod { get; set; }

//    public FixedDepositAccount(BankAccount bankAccount, int maturityPeriod)
//    {
//        BankAccount = bankAccount;
//        MaturityPeriod = maturityPeriod;
//    }

//    public void DisplayAccountType()
//    {
//        Console.WriteLine($"Account Type: Fixed Deposit Account, Maturity Period: {MaturityPeriod} months");
//    }

//    public string GetAccountDetails()
//    {
//        return $"{BankAccount.GetAccountDetails()}, Maturity Period: {MaturityPeriod} months";
//    }
//}

//class BankAccountManagement
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter Account Number: ");
//        string accountNumber = Console.ReadLine();

//        Console.Write("Enter Initial Balance: ");
//        double balance = double.Parse(Console.ReadLine());

//        Console.Write("Enter Savings Account Interest Rate: ");
//        double interestRate = double.Parse(Console.ReadLine());

//        Console.Write("Enter Checking Account Withdrawal Limit: ");
//        double withdrawalLimit = double.Parse(Console.ReadLine());

//        Console.Write("Enter Fixed Deposit Maturity Period (in months): ");
//        int maturityPeriod = int.Parse(Console.ReadLine());

//        BankAccount bankAccount = new BankAccount(accountNumber, balance);
//        SavingsAccount savingsAccount = new SavingsAccount(bankAccount, interestRate);
//        CheckingAccount checkingAccount = new CheckingAccount(bankAccount, withdrawalLimit);
//        FixedDepositAccount fixedDepositAccount = new FixedDepositAccount(bankAccount, maturityPeriod);

//        Console.WriteLine("\nAccount Details:\n");

//        savingsAccount.DisplayAccountType();
//        Console.WriteLine(savingsAccount.GetAccountDetails());

//        checkingAccount.DisplayAccountType();
//        Console.WriteLine(checkingAccount.GetAccountDetails());

//        fixedDepositAccount.DisplayAccountType();
//        Console.WriteLine(fixedDepositAccount.GetAccountDetails());
//    }
//}
