namespace OOP.Interfaces.IEnumerators
{
    public class Product 
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public override string ToString()
        {
            return $"{ProductId} {ProductName} {ProductPrice}";
        }
    }
}