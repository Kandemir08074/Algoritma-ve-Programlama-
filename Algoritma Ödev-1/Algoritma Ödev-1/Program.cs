namespace Algoritma_Ödev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[5, 3];
            Random rnd = new Random();
            Console.WriteLine("Üretilen matris: ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("[");
                for (int j = 0; j < 3; j++)
                {
                    dizi[i, j] = rnd.Next(0, 10);

                    Console.Write(dizi[i, j]);
                    if (j < 2)
                    {
                        Console.Write(",");
                    }

                }
                Console.WriteLine("]");
            }
            Console.WriteLine("");
            Console.WriteLine("Sütun Toplamları:");
            Console.Write("Sütun 1: ");
            int s1 = 0;
            for (int i = 0; i < 5; i++)
            {
                s1 = s1 + dizi[i, 0];

            }
            Console.Write(s1);
            Console.WriteLine("");
            Console.Write("Sütun 2: ");
            int s2 = 0;
            for (int i = 0; i < 5; i++)
            {
                s2 = s2 + dizi[i, 1];
            }
            Console.Write(s2);
            Console.WriteLine("");
            Console.Write("Sütun 3: ");
            int s3 = 0;
            for (int i = 0; i < 5; i++)
            {
                s3 = s3 + dizi[i, 2];
            }
            Console.Write(s3);
        }
    }
}
