namespace SourceCodePrettyHair
{
    public class ProductType
    {
        public int Amount;
        public string Description;
        public double Price;
        public int ID;

        public ProductType()
        {
            
        }

 
        public ProductType(int id,string description, double price, int amount)
        {
            Amount = amount;
            Price = price;
            Description = description;
            ID = id;


        }
        public void WithdrawAmount(int withdrawAmount)
        {
            Amount = Amount - withdrawAmount;

        }

        public bool InStock(int OrderAmount)
        {
            bool inStock = false;
            if (Amount >= OrderAmount)
            { inStock = true; }
            return inStock;
        }

        



    }
}