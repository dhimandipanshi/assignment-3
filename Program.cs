// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

public class Account
{
    public string AccountNumber { get; }
    public double Balance { get; private set; }
    public string AccountType { get; }

    public Account(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
        AccountType = "checking";
    }

    public Account(string accountNumber, double balance, string accountType)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        AccountType = accountType;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
        }
    }

    public void Deposit(params double[] amounts)
    {
        foreach (double amount in amounts)
        {
            Deposit(amount);
        }
    }

    public void Withdraw(params double[] amounts)
    {
        foreach (double amount in amounts)
        {
            Withdraw(amount);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Account checkingAccount = new Account("178942789");

        Account savingsAccount = new Account("923486921", 2000, "savings");

        checkingAccount.Deposit(7069);

        savingsAccount.Withdraw(709);

        checkingAccount.Withdraw(300, 100);

        Console.WriteLine("Checking Account Balance: $" + checkingAccount.Balance);
        Console.WriteLine("Savings Account Balance: $" + savingsAccount.Balance);
    }
}