namespace SearchEngine.Entities
{
    public class CartItem
    {
        public int ID { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int BookId { get; set; }
        public Books Book { get; set; }
        public int Quantity { get; set; }
    }
}
