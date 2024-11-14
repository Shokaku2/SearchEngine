namespace SearchEngine.Entities
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int BookId { get; set; }
        public Books Book { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
