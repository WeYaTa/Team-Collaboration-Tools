using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSTeamCollab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x = 3; N = 10; Hasil : "+ SumX(3,10));
            Console.WriteLine("x = 1; N = 10; Hasil : " + SumX(1, 10));
            Console.WriteLine("x = 0; N = 10; Hasil : " + SumX(0, 10));
            Console.WriteLine("x = -1; N = 10; Hasil : " + SumX(-1, 10));
            Console.WriteLine("x = -1; N = -10; Hasil : " + SumX(-1, -10));
            Console.WriteLine("x = -15; N = -1000; Hasil : " + SumX(-15, -1000));
            Console.WriteLine("x = -1; N = -1; Hasil : " + SumX(-1,-1));
            Console.WriteLine("x = -15; N = -1001; Hasil : " + SumX(-15, -1001));
        }

        public static int SumX(int x, int N)
        {
            int hasil = 0;
            if (x < -1000 || x > 1000 || N < -1000 || N > 1000)
            {
                Console.WriteLine("Maaf, angka melebihi batas");
            }
            else
            {
                if (x < 0 && N >= 0)
                {
                    hasil = 0;
                }
                else if (x > 0 && N <= 0)
                {
                    hasil = 0;
                }
                else if (x == 0)
                {
                    hasil = 0;
                }
                else if (x >=0 && N >=0)
                {
                    int temp = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        if (i % x == 0)
                        {
                            temp += i;
                        }
                    }
                    hasil = temp;
                }
                else if (x < 0 && N <0)
                {
                    int temp = 0;
                    for (int i = 1; i <= N*-1 ; i++)
                    {
                        if (i % x*-1 == 0)
                        {
                            temp += i;
                        }
                    }
                    hasil = temp * -1;
                }
            }
            return hasil;
        }
    }
}
