namespace Algoritma_Ödev___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. kanguru için hangi konumda olduğunu olduğunu ve 1 adımda ne kadar gideceğini belirleyin... ");
            Console.Write("-> ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("-> ");
            int V1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. kanguru için hangi konumda olduğunu ve 1 adımda ne kadar ilerleyceğini belirleyin... ");
            Console.Write("-> ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("-> ");
            int V2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                if (X1 + (V1 * i) == X2 + (V2 * i))
                {
                    Console.WriteLine("BULUŞTULAR!");
                    Console.WriteLine($"{i}. zıplayışta {X2 + (V2 * i)} konumunda buluştular!");
                    break;
                }
                else if (X1 + (V1 * i) != X2 + (V2 * i))
                {
                    Console.WriteLine("MAALESEF BULUŞAMADILAR!");
                    break;
                }
            }
            
            
            
        }
    }
}
