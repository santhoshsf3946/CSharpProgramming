namespace Question3
{
    public interface ICalculate
    {
        void Deposit(int amount);

        void Withdraw(int amount);

        void CheckBalance();
    }
}