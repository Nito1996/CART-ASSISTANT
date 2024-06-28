namespace CartAssistant
{
    public class CartItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; } = 0;
        public CartItem(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}