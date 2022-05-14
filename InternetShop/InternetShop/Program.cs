namespace InternetShop
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Service.OrderService orderService = new Service.OrderService();
            orderService.MakeOrder();
            Service.AlertService alert = new Service.AlertService();
            Console.WriteLine("Accept the order (enter: Yes or No): ");
            string answer = Console.ReadLine();
            alert.AlertCustomer(answer);
        }
    }
}
