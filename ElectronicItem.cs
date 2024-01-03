

namespace Shoppingspree
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
        protected string ForsikringInfo { get; set; }
        protected int Spenning { get; set; }

       
        public ElectronicItem(string name, int antall, double pris, string forsikringInfo, int spenning) : base(name, antall, pris)
        {
            ForsikringInfo = forsikringInfo;
            Spenning = spenning;
        }
        public double CalulateSalePrice()
        {
            double salePrice = Antall * Pris;
            return salePrice;
        }
    }
}
