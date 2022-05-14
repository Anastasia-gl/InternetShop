namespace InternetShop.Models
{
    internal class Basket
    {
        public string[] Clothes { get; set; } = new string[10];

        public int AmountInBasket { get; set; }
    }
}
