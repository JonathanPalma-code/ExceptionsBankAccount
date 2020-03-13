using ExceptionsBankAccount.Entities.Exceptions;

namespace ExceptionsBankAccount.Entities
{
    class Account
    {
        public int Id { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithrawLimit { get; set; }

        public Account(int id, string holder, double balance, double withrawLimit)
        {
            if (balance <= 0 || withrawLimit <= 0)
            {
                throw new DomainException("Balance and Withraw Limit need to be more than 0 ");
            }
            Id = id;
            Holder = holder;
            Balance = balance;
            WithrawLimit = withrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new DomainException("Amount need to be more than 0");
            }
            Balance += amount;
        }

        public void Withraw(double amount)
        {
            if (amount <= 0)
            {
                throw new DomainException("Amount need to be more than 0");
            }
            else if (amount >= WithrawLimit)
            {
                throw new DomainException("the amount exceeds the withraw limit");
            }
            else if (amount >= Balance)
            {
                throw new DomainException("Insufficient founds.");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return  $"New Balance: {Balance.ToString("F2")}";
        }
    }
}
