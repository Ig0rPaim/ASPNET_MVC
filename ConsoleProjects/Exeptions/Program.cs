using Exeptions.Entities;
using Exeptions.Exeptions;

internal class Program
{
    private static void Main(string[] args)
    {
        //try
        //{
        //    int n1 = int.Parse(Console.ReadLine());
        //    int n2 = int.Parse(Console.ReadLine());
        //    int result = n1 / n2;
        //    Console.WriteLine(result);
        //}
        //catch (DivideByZeroException)
        //{
        //    Console.WriteLine("Division by zero is not allowed");
        //}
        //catch (FormatException e)
        //{
        //    Console.WriteLine("Format error! " + e.Message);
        //}

        //////////////////////

        //FileStream fs = null;
        //try
        //{
        //    fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
        //    StreamReader sr = new StreamReader(fs);
        //    string line = sr.ReadLine();
        //    Console.WriteLine(line);
        //}
        //catch (FileNotFoundException e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        //finally
        //{
        //    if (fs != null)
        //    {
        //        fs.Close();
        //    }
        //}

        try
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int Number = int.Parse(Console.ReadLine()!);
            Console.Write("Holder: ");
            string Holder = Console.ReadLine()!;
            Console.Write("Initial balance: ");
            double Balace = double.Parse(Console.ReadLine()!);
            Console.Write("Withdraw limit: ");
            double WithdrawLimit = double.Parse(Console.ReadLine()!);

            Console.Write("Enter amount for withdraw: ");
            double Amount = double.Parse(Console.ReadLine()!);

            Account account = new Account(Number, Holder, Balace, WithdrawLimit);
            account.Withdraw(Amount);
        }
        catch (WithdrawLimitExeption e)
        {
            Console.WriteLine("Withdraw error: " + e.Message);
        }
        catch (NoBalanceExeption e)
        {
            Console.WriteLine("Withdraw error: " + e.Message);
        } 

    }
}