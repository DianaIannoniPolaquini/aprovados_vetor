using System;
using System.Globalization;

namespace APROVADOS_VETORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string[] nome = new string[x];
            double[] n1 = new double[x];
            double[] n2 = new double[x];

            for (int i = 0; i < x; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                n1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                n2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            double media;
            for (int i = 0; i < x; i++)
            {
                media = (n1[i] + n2[i]) / 2.0;
                if (media >= 6)
                {
                    Console.WriteLine(nome[i]);
                }
            }

        }
    }
}

