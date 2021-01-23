using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> Products = new MyDictionary<string, int>();
            Products.Add("Masa", 250);
            Products.Add("Sandalye", 75);
            Products.Add("Koltuk", 700);
            Products.Add("Sehpa", 200);
            Products.Add("Dolap", 400);
            Products.Add("Yatak", 1500);

        }
    }
}
