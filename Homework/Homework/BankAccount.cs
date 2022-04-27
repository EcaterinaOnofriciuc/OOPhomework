namespace Homework
{
    internal class BankAccount
    {
        private float _amount = 0;

        // overloading
        public void AddMoney(float money)
        {
            if (money < 0)
            {
                Console.WriteLine("Should be positive value");
            }
            else
            {
                _amount += money;
            }
        }

        // overloading
        public void AddMoney(int money, int taxes)
        {
            if (money < 0)
            {
                Console.WriteLine("Should be positive value");
            }
            else
            {
                _amount += money - taxes;
            }
        }
        public void WithdrawMoney(float money)
        {
            if (money < 0)
            {
                Console.WriteLine("Should be positive value");
            }
            else if (money > _amount)
            {
                Console.WriteLine("You don't have enough money");
            }
            else
            {
                _amount -= money;
            }
        }
        public float GetAmount()
        {
            Console.WriteLine($"You have {Math.Round(_amount, 2)}");
            return _amount;
        }
    }
}
