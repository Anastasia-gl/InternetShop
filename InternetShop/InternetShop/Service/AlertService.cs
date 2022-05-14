namespace InternetShop.Service
{
    public class AlertService
    {
        public void AlertCustomer(string answer)
        {
            if (answer == "Yes")
            {
                Console.WriteLine("The order is processed. The confirm of the order is successful");
            }
            else if (answer == "No")
            {
                Console.WriteLine("The order is canceled");
            }
        }
    }
}
