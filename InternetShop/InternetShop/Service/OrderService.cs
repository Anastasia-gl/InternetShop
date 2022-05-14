namespace InternetShop.Service
{
    public class OrderService
    {
        public int IdOrder { get; set; }

        public int TotalSum { get; set; }

        public int[] arrayValue { get; set; } = new int[10];

        BasketService addBasket = new BasketService();
        Random random = new Random();
        Models.Shop shop = new Models.Shop();
        Models.Basket basket = new Models.Basket();

        public void CountTotalSum()
        {
            for (int i = 0; i < arrayValue.Length; i++)
            {
                TotalSum += arrayValue[i];
            }

            Console.WriteLine($"\t\tTotal price: {TotalSum}$");
        }

        public void NoteThePrice()
        {
            int index = 0;
            string[] pickedClothes = addBasket.AddToBasketService(shop.Clothes);

            foreach (string item in pickedClothes)
            {
                shop.Value = random.Next(5, 120);
                basket.AmountInBasket = random.Next(0, 3);

                if (basket.AmountInBasket == 0)
                {
                    Console.WriteLine($"{item}\t\t\t-\t\t\t{shop.Value * 0}$");
                }
                else if (basket.AmountInBasket > 0)
                {
                    arrayValue[index++] += shop.Value * basket.AmountInBasket;
                    Console.WriteLine($"{item}\t\t\t{basket.AmountInBasket}\t\t\t{shop.Value }$");
                }
            }
        }

        public void MakeOrder()
        {
            IdOrder = random.Next(0, 1000);
            Console.WriteLine($"\t\tOrder number: {IdOrder}");
            NoteThePrice();
            CountTotalSum();
        }
    }
}