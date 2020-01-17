using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCD_ASC
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Functie pentru a scrie o cifra in baza 2 pe 4 biti
            Console.WriteLine("Nr. de convertit in BCD: ");
            int n = int.Parse(Console.ReadLine());
            int[] vn = new int[4];
            int contor = 0;

            Console.WriteLine($"{n} in baza 2 este: ");
            if (n>=0) // mai mare sau egal decat 0 , nu diferit de 0
            {
                while (n!=0)
                {
                    vn[contor] = n % 10;
                    n = n / 10;
                    contor++;
                }

                for (int i = vn.Length - 1; i >= 0; i--)
                {
                    toBaza2(vn[i]);
                    Console.Write(" ");
                }
            }
            else
            {
                int m = (9999 + n) + 1; // pentru a putea scadea un nr negativ trebuie sa il punem cu +
                while (m != 0 )
                {
                    vn[contor] = m % 10;
                    m = m / 10;
                    contor++;
                }

                for (int i = vn.Length -1; i >= 0; i--)
                {
                    toBaza2(vn[i]);
                    Console.Write(" ");
                }
            }
        }

        private static void toBaza2(int x)
        {
            int[] v = new int[4];
            int contor = 0;
            while (x!=0)
            {
                v[contor] = x % 2;
                x = x / 2;
                contor++;
            }

            for (int i = v.Length - 1; i >= 0; i--)
            {
                Console.Write(v[i]);
            }
        }
    }
}
