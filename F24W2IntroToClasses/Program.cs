namespace F24W2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product(101, "Laptop", 1200);


            AccountWithMethods myAcc = new AccountWithMethods(100);
            Console.WriteLine("\nBalance: " + myAcc.GetBalance().ToString("C"));

            myAcc.Deposit(500);
            Console.WriteLine("\nBalance: " + myAcc.GetBalance().ToString("C"));

            try
            {
                myAcc.Withdraw(2000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nBalance: " + myAcc.GetBalance().ToString("C"));
            }
        }
    }
}
