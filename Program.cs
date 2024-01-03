namespace Shoppingspree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pants = new ClothingItem("Levis", 2, 899.50, "XL", "dongeri");
            var phone = new ElectronicItem("Nokia 3310", 3, 3000, "3-års garanti", 20);

            Console.WriteLine("Hva koster buksa?");
            Console.ReadKey();
            Console.WriteLine(pants.CalulateSalePrice());

            Console.WriteLine("Hva koster telefonen?");
            Console.ReadKey();
            Console.WriteLine(phone.CalulateSalePrice());
            ;
        }
    }
}
