using System;

namespace _20210505
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Suma, produsul si media aritmetica a primelor n numere (1,2,3) 
             */
            int Suma = 0, Produs = 1;
            
            Console.WriteLine("Numar: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Suma += i;
                Produs *= i;
            }
            Console.WriteLine("Suma: " + Suma);
            Console.WriteLine("Produs: " + Produs);
            Console.WriteLine("MediaAritmetica: " + Suma / n);

            /*
             * Numar prim (4) 
             */
            static bool estePrim(int n)
            {
                if (n < 4 && n>0) return true;
                bool Check = true;
                for (int i = 2; i < n; i++)
                    if (n % i == 0)
                        Check = false;
                return Check;
            }

            if (estePrim(n))
                Console.WriteLine(n + " este prim!");
            else
                Console.WriteLine(n + " nu este prim!");

            /*
             * Primele n numbere prime (5)
             */
            int count = 0,temp=1;
            while (count < n)
                if (estePrim(temp))
                {
                    Console.WriteLine(temp);
                    count++;
                    temp++;
                }
                else
                    temp++;
        }
    }
}