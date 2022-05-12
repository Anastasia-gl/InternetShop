namespace InternetShop
{
    public class AddToBasket
    {
        Basket basket = new Basket();
        Random random = new Random();

        public string[] AddToBasketService(string[] clothes)
        {
            for (int i = 0; i < basket.Clothes.Length; i++)
            {
                int index = random.Next(clothes.Length);
                basket.Clothes[i] = clothes[index];
            }

            return basket.Clothes;
        }
    }
}
