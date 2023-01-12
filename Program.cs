using System;

namespace prumer_znamek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Z kolika známek chceeč počítat průměr?");
            int pocet_znamek = int.Parse(Console.ReadLine());
            int[] znamky = new int[pocet_znamek];
            for (int posun_indexu = 0; posun_indexu < pocet_znamek; posun_indexu++)
            {
                Console.WriteLine("Zadejte {0}. známku", posun_indexu + 1);
                znamky[posun_indexu] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Průměr tvých známek je:{0}", znamky.Min());
            Console.ReadKey();
        }
    }
}
