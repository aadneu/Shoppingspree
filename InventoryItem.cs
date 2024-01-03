
namespace Shoppingspree
{
    internal abstract class InventoryItem
    {
        public string Name { get;  }
        public int Antall { get; }
        public double Pris { get; }

        protected InventoryItem(string name, int antall, double pris)
        {
            Name = name;
            Antall = antall;
            Pris = pris;
        }
    }
}
