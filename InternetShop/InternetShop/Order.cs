using System.Globalization;

namespace InternetShop
{
    public class Order
    {
        public int IdOrder { get; set; }

        public int TotalSum { get; set; }

        public int Value { get; set; }

        public int[] arrayValue { get; set; } = new int[10];

        AddToBasket addToBasket = new AddToBasket();
        Random random = new Random();
        MainShop mainShop = new MainShop();

        public void CountTotalSum()
        {
            for (int i = 0; i < arrayValue.Length; i++)
            {
                TotalSum += arrayValue[i];
            }

            Console.WriteLine($"\tИтоговая сумма: {TotalSum.ToString("C2", CultureInfo.CurrentCulture)}");
        }

        public void NoteThePrice()
        {
            int index = 0;
            string[] pickedClothes = addToBasket.AddToBasketService(mainShop.Clothes);
            foreach (string item in pickedClothes)
            {
                Value = random.Next(5, 120);
                arrayValue[index++] += Value;
                Console.WriteLine($"{item}\t\t\t{Value.ToString("C2", CultureInfo.CurrentCulture)}");
            }
        }

        public void MakeOrder()
        {
            IdOrder = random.Next(0, 1000);
            Console.WriteLine($"\tНомер заказа: {IdOrder}");
            NoteThePrice();
            CountTotalSum();
        }
    }
}
