namespace Pastry_And_Pour_Jurczak.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public List<string> Items { get; set; }
        public double Total { get; set; }
        public string Status { get; set; }
    }
}
