public sealed class DIExample
{
    private void Main()
    {
        new User(new Qiwi()).Pay();
    }

    class User
    {
        private IPay _pay;

        public User(IPay pay)
        {
            _pay = pay;
        }
        
        public void Pay()
        {
        }
    }

    class Qiwi : IPay
    {
        public decimal Money { get; set; }
    }

    interface IPay
    {
        decimal Money { get; set; }
    }
}