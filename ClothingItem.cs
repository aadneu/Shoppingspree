

namespace Shoppingspree 
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        protected string Size { get; set; }
        protected string Color { get; set; }


        public ClothingItem(string name, int antall, double pris, string size, string color) : base(name, antall, pris)
        {
            Size = size;
            Color = color;
        }

        public double CalulateSalePrice()
        {
            double salePrice = Antall * Pris;
            return salePrice;
        }
    }
}
