//using C_2.Entities;
//using C_2.Entities.Enums;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Order os = new Order
//        {
//            Id = 1,
//            Moment = DateTime.Now,
//            Status = OrderStatus.PendingPayment,
//        };

//        Console.WriteLine(os);

//        string txt = OrderStatus.PendingPayment.ToString();

//        Console.WriteLine(txt);

//        OrderStatus os_2 = Enum.Parse<OrderStatus>("Delivered");

//        Console.WriteLine(os_2);

//    }
//}