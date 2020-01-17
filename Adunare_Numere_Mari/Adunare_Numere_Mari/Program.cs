using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adunare_Numere_Mari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adunarea a 2 numere mari 
            Console.WriteLine("Introdu primul si al 2 lea nr: ");
            string line1, line2;
            line1 = Console.ReadLine();
            line2 = Console.ReadLine();

            int[] a = new int[1000];
            int[] b = new int[1000];
            int[] c = new int[1000];

            int cifra;
            int contor = 0;

            // introducem cifrele in vectori din string de la dreapta la stanga 
            for (int i = line1.Length - 1; i >=0 ; i--)
            {
                cifra = line1[i] - 48; // scadem 48 din string sa il transformam in int
                a[contor] = cifra;
                contor++;
            }
            contor = 0;

            for (int i = line2.Length - 1; i >= 0; i--)
            {
                cifra = line2[i] - 48; // scadem 48 din string sa il transformam in int
                b[contor] = cifra;
                contor++;
            }

            int carry = 0;
            // adunam cifrele in al 3 lea vector
            for (int i = 0; i < 1000; i++)
            {
                c[i] = (a[i] + b[i] + carry) % 10;
                carry = (a[i] + b[i] + carry) / 10;
            }

            bool gasit = false;

            for (int i = 999; i >= 0; i--)
            {
                if (c[i]!=0)
                {
                    gasit = true;
                }
                if (gasit)
                {
                    Console.Write(c[i]);
                }
            }
            Console.WriteLine();

        }
    }
}
