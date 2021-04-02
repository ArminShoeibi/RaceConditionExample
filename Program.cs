using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using RaceConditionExample.Entities;

namespace RaceConditionExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Task> tasks = new();
            BankAccount myBankAccount = new();

            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run(() => 
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        myBankAccount.Deposit(100);
                        Console.WriteLine($"TaskId: {Task.CurrentId} \t ThreadId: {Thread.CurrentThread.ManagedThreadId} \t Depositing bank account (+100) \t Current Balance: ${myBankAccount.Balance}");
                    }
                }));

                tasks.Add(Task.Run(() =>
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        myBankAccount.Withdraw(100);
                        Console.WriteLine($"TaskId: {Task.CurrentId} \t ThreadId: {Thread.CurrentThread.ManagedThreadId} \t Withdrawing bank account (-100) \t Current Balance: ${myBankAccount.Balance}");
                    }
                }));
            }

            await Task.WhenAll(tasks);
            Console.WriteLine($"Final Balance is {myBankAccount.Balance}");
        }
    }
}
