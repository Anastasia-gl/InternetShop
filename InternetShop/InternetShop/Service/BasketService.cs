namespace InternetShop.Service
{
    internal class BasketService
    {
        Models.Basket basket = new Models.Basket();
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
