using FinanceManagementSystem;



namespace FinanceManagementSystem
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("App started");
            Console.WriteLine("*******************************");
            Console.WriteLine("***Finance Management System***");

            FinanceApp financeApp = new FinanceApp();
            financeApp.Run();



            Console.ReadKey();
        }
    }
}