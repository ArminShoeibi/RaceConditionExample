namespace RaceConditionExample.Entities
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }
        public void Deposit(decimal amount) => Balance += amount;
        public void Withdraw(decimal amount) => Balance -= amount;
    }
}
