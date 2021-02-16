using System;

namespace Uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, n, n1,n2;

            n = 0;
            n1 = 0;
            n2 = 0;

            string[] vetor = Console.ReadLine().Split(' ');
            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);

            if(a < b && a < c)
            {
                n = a;

                if(b<c)
                {
                    n1 = b;
                    n2 = c;
                }
                else
                {
                    n1 = c;
                    n2 = b;
                }

            }
            if (b < a && b < c)
            {
                n = b;

                if (a < c)
                {
                    n1 = a;
                    n2 = c;
                }
                else
                {
                    n1 = c;
                    n2 = a;
                }

            }

            if (c < a && c < b)
            {
                n = c;

                if (a < b)
                {
                    n1 = a;
                    n2 = b;
                }
                else
                {
                    n1 = b;
                    n2 = a;
                }

            }

            Console.WriteLine();
            Console.WriteLine(n);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);



        }
    }
}
