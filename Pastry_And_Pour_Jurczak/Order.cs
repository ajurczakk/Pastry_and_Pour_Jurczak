namespace Pastry_And_Pour_Jurczak
{
    //  ORDER CLASS REPRESENTS A CUSTOMER'S ORDER
    public class Order
    {
        //  PROPERTY FOR ORDER ID
        public int Id { get; set; }

        //  PROPERTY FOR CUSTOMER NAME
        public string CustomerName { get; set; }

        //  PROPERTY FOR SELECTED PASTRY ITEM
        public string PastryItem { get; set; }

        //  PROPERTY FOR SELECTED DRINK
        public string DrinkItem { get; set; }

        //  PROPERTY FOR ORDER TOTAL PRICE
        public decimal TotalPrice { get; set; }

        
        public Order()
        {
            
            CustomerName = "";
            PastryItem = "";
            DrinkItem = "";
            TotalPrice = 0;
        }
    }
}
