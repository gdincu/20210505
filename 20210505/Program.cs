using System;

namespace _20210505
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Sa se calculeze suma primelor n numere, unde n se citeste de la tastatura.
             * Sa se calculeze produsul primelor n numere, unde n se citeste de la tastatura.
             * Se citesc n numere de la tastatura sa se determine suma, produsul si media artimetica a acestora.
             */
            int Suma = 0, Produs = 1;
            
            Console.Write("Numar: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Suma += i;
                Produs *= i;
            }
            Console.Write("\n1) Suma: " + Suma);
            Console.Write("\n2) Produs: " + Produs);
            Console.Write("\n3) MediaAritmetica: " + Suma / n);

            /*
             * Se citeste un numar de la tastatura sa se determine daca este prim sau nu
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
                Console.Write("\n4) " + n + " este prim!");
            else
                Console.Write("\n4) " + n + " nu este prim!");

            /*
             * Sa se afiseaza primele n numere prime, un n este dat de la tastatura
             */
            int count = 0,temp=1;
            Console.Write("\n6) Primele " + n + " numere prime:");
            while (count < n)
                if (estePrim(temp))
                {
                    Console.Write(" " + temp);
                    count++;
                    temp++;
                }
                else
                    temp++;

            /*
             * Se citeste un numar de la tastatura sa se afiseze toti divizorii acestuia.
             */
            temp = 0; 
            Console.Write("\n7) Divizori " + n + " :");
            do {
                temp++;
                if (n % temp == 0)
                    Console.Write(" " + temp);
            }
            while (temp <= n / 2);
            Console.Write(" " + n);

            /*
             * Sa se calculeze fibonacci pt n
             */
            temp = 1;count = 1;
            int temp2 = 0;
            Console.Write("\n8) Fibonacci pentru " + n + " : 1");
            
            while (count < n)
            {
                Console.Write(" " + (temp + temp2));
                int temp3 = temp2;
                temp2 = temp;
                temp += temp3;
                count++;
            }

            /*
             * Se citesc numere de la tastatura pana la intalnirea unui numar mai mare ca 100
             */
            temp = 0;
            Console.Write("\n9) Un nr mai mare ca 100?\n");
            while (temp <= 100) {
                Console.Write("Nr: ");
                temp = int.Parse(Console.ReadLine());
            }
            Console.Write("Nr final: " + temp);

            /*
             * Sa se scrie un program care citeste un număr intreg si care determina corespondetul acestuia in binar folosind algoritmului de impartire la doi. 
             * Sa se afiseze numarul binar. E.g.: Dati nr intreg: 28 
             * Echivalentul lui 28 in binar este 11100
            */
            Console.Write("\n10) " + n + " in binar: ");
            String rezBinar = "";
            while (n > 0) {
                rezBinar += n % 2;
                n /= 2;
            }

            String rezFinal = "";
            for (int i = rezBinar.Length-1; i >= 0; i--)
                rezFinal += rezBinar[i];
            Console.Write(rezFinal);

            /*
             * Sa se scrie un program care citeste o data de la tastatura si determina ziua saptamanii in care se afla acea data. E.g. Dati ziua: 3 Dati luna: 5 Dati anul: 2021 Aceasta data se afla intr-o zi de luni.
            */
            
            Console.Write("\n11)Zi/Luna/An: ");
            DateTime tt = DateTime.Parse(Console.ReadLine());

            Console.Write("Aceasta data se afla intr - o zi de ");
            switch (tt.DayOfWeek.ToString())
            {
                case "Monday":
                    Console.Write("Luni");
                    break;
                case "Tuesday":
                    Console.Write("Marti");
                    break;
                case "Wednesday":
                    Console.Write("Miercuri");
                    break;
                case "Thursday":
                    Console.Write("Joi");
                    break;
                case "Friday":
                    Console.Write("Vineri");
                    break;
                case "Saturday":
                    Console.Write("Sambata");
                    break;
                case "Sunday":
                    Console.Write("Duminica");
                    break;
                default:
                    Console.Write(" ");
                    break;
            }


            /*
             * Sa se citeasca o data, sa se determine care este ultima zi din luna acele date
             */
            Console.Write("\n12) Ultima zi din luna datei alese este: ");
            switch(tt.Month)
            {
                case 1:
                    Console.Write("31/"+tt.Month+"/"+tt.Year);
                    break;
                case 2:
                    if (DateTime.IsLeapYear(tt.Year))
                    Console.Write("29/" + tt.Month + "/" + tt.Year);
                    else
                    Console.Write("28/" + tt.Month + "/" + tt.Year);
                    break;
                case 3:
                    Console.Write("31/" + tt.Month + "/" + tt.Year);
                    break;
                case 4:
                    Console.Write("30/" + tt.Month + "/" + tt.Year);
                    break;
                case 5:
                    Console.Write("31/" + tt.Month + "/" + tt.Year);
                    break;
                case 6:
                    Console.Write("30/" + tt.Month + "/" + tt.Year);
                    break;
                case 7:
                    Console.Write("31/" + tt.Month + "/" + tt.Year);
                    break;
                case 8:
                    Console.Write("31/" + tt.Month + "/" + tt.Year);
                    break;
                case 9:
                    Console.Write("30/" + tt.Month + "/" + tt.Year);
                    break;
                case 10:
                    Console.Write("31/" + tt.Month + "/" + tt.Year);
                    break;
                case 11:
                    Console.Write("30/" + tt.Month + "/" + tt.Year);
                    break;
                case 12:
                    Console.Write("31/" + tt.Month + "/" + tt.Year);
                    break;
                default:
                    Console.WriteLine(" ");
                    break;
            }

            /*
             * Se citesc doua date. Sa se determine care este cea mai recentă.
             */
            Console.Write("\n13)Zi/Luna/An: ");
            DateTime tt1 = DateTime.Parse(Console.ReadLine());
            Console.Write("\nZi/Luna/An: ");
            tt = DateTime.Parse(Console.ReadLine());
            if (tt1.CompareTo(tt) > 0)
                Console.WriteLine(tt1 + " este mai recenta decat " + tt);
            else
                Console.WriteLine(tt + " este mai recenta decat " + tt1);

            /*
             * Sa se citeasca o data si sa se converteasca: 
             * in short time string representation
             * ln long time string representation
             * in formatul unei alte culturi (E.g. franceza, engleza)
             * in universal time format (UTC)
             */
            Console.Write("\n14)Zi/Luna/An: ");
            tt = DateTime.Parse(Console.ReadLine());

            Console.Write("\nShortTimeString: " + tt.ToShortTimeString());
            Console.Write("\nLongTimeString: " + tt.ToLongTimeString());
            Console.Write("\nLocalFormat: " + tt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR")));
            Console.Write("\nUTC: " + tt.ToUniversalTime());








        }
    }
}