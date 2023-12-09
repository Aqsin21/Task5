using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace ConsoleTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // task 1

            Console.WriteLine("4reqemli eded daxil edin: ");
        l1:
            string astr = Console.ReadLine();
            if (int.TryParse(astr, out int a) && astr.Length == 4)
            {
                int sum = 0;
                while (a > 0)
                {
                    sum += a % 10;
                    a /= 10;
                }
                Console.WriteLine(sum);

            }
            else
            {
                Console.WriteLine("daxil edilen eded sertleri odemir");
                goto l1;
            }

            // task 2

            Console.WriteLine("6 reqemli eded daxil edin");
        l2:
            string bstr = Console.ReadLine();
            if (int.TryParse(bstr, out int b) && bstr.Length == 6)
            {
                int sum = 0;
                int b1 = b / 1000;
                while (b1 > 0)
                {
                    sum += b1 % 10;
                    b1 /= 10;
                }
                Console.WriteLine(sum);
            }
            else
            {
                goto l2;
            }
            //task3

            Console.WriteLine("9 reqemli eded daxil edin:");
        l3:
            string cstr = Console.ReadLine();

            if (int.TryParse(cstr, out int c) && cstr.Length == 9)
            {
                int sum = 0;
                int c1 = c / 1000;
                int i = 0;


                while (c1 > 0 && i < 3)
                {


                    sum += c1 % 10;
                    c1 /= 10;
                    i++;


                }

                Console.WriteLine(sum);

            }
            else
            {
                Console.WriteLine("eded 9reqemli deyil!");
                goto l3;
            }



            // task 4

            Console.WriteLine("5 reqemli ede daxil edin");
        l4:
            string dstr = Console.ReadLine();

            if (int.TryParse(dstr, out int d) && dstr.Length == 5)
            {
                int d0 = d / 10000;
                int d4 = d % 10;
                int sum = (d0 + d4);
                double exp = sum;
                double high = 2;
                double result = Math.Pow(exp, high);


                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("daxil edilen eded sertleri odemir");
                goto l4;
            }

            // task 5

            Console.WriteLine(" 6 reqemli eded daxil edin");
        l5:
            string estr = Console.ReadLine();
            if (int.TryParse(estr, out int e) && estr.Length == 6)
            {
                int e1 = e / 100000;
                int e2 = e % 100000;
                int e3 = (e2 * 10) + e1;
                Console.WriteLine(e3);
            }
            else
            {
                Console.WriteLine("daxil edilen eded sertleri odemir");
                goto l5;
            }

            // task 6

            Console.WriteLine(" 8 reqemli eded daxil edin");
        l6:
            string fstr = Console.ReadLine();
            if (int.TryParse(fstr, out int f) && fstr.Length == 8)
            {
                int f1 = f / 10;
                int f2 = f1 % 1000000;
                Console.WriteLine(f2);
            }
            else
            {
                Console.WriteLine("daxil edilen eded sertleri odemir");
                goto l6;
            }

            // task 7
            Console.WriteLine("4 reqemli eded daxil edin");
        l7:
            string gstr = Console.ReadLine();
            if (int.TryParse(gstr, out int g) && gstr.Length == 4)
            {
                int g1 = g % 10;
                int g2 = g / 10;
                int g3 = g2 % 10;
                int g4 = g / 100;
                int g5 = g3 % 10;
                int g6 = g % 1000;
                int sum7 = (g1 * 1000) + (g3 * 100) + (g5 * 10) + g6;
                int sum71 = 800008 + sum7 * 10;
                Console.WriteLine(sum71);


            }


            else
            {
                Console.WriteLine("daxil edilen eded sertleri odemir");
                goto l7;
            }

            // task 8 

            Console.WriteLine("eded daxil edin");
            string hstr = Console.ReadLine();
            if (int.TryParse(hstr, out int h) && hstr.Length >= 4)
            {
                int h1 = (h / 100) % 10 + h % 10;
                Console.WriteLine(h1);
            }
            else
            {
                Console.WriteLine("daxil edilen eded sertleri odemir");
            }

            // task 9





            Console.WriteLine("9 reqemli eded daxil edin");
        l9:
            string jstr = Console.ReadLine();
            if (int.TryParse(jstr, out int j) && jstr.Length == 9)
            {
                int j11 = j / 10;
                int m11 = j / 100; int m1 = m11 % 10;
                int n11 = j / 10000; int n1 = n11 % 10;
                int o11 = j / 1000000; int o1 = o11 % 10;
                int p11 = j / 100000000; int p1 = p11 % 10;
                int sum9 = (p1 * 10000) + (o1 * 1000) + (n1 * 100) + (m1 * 10) + j11;
                Console.WriteLine(sum9);
            }

            else
            {
                Console.WriteLine("daxil edilen eded sertleri odemir");
                goto l9;
            }

            // task 10

                            Console.WriteLine("8 reqemli eded daxil edin");
            string rstr = Console.ReadLine();
            if (int.TryParse(rstr, out int r) && rstr.Length == 8)
            {
                int r11 = r / 1000000;
                int r22 = r % 100;
                int r33 = (r / 100) % 100;
                int r44 = (r / 10000) % 100;
                Console.WriteLine($"bu ededin reqemleri iki iki qruplasdirildi: {r11}, {r44}, {r33} ve {r22}");
                int sum11 = r11 + r22 + r33 + r44;
                Console.WriteLine($"bu qrupdaki ededlerin cemi tapilir: {sum11}");
                int sum112 = sum11 * 100 + 99;
                Console.WriteLine($"alinan cavabina axirina 99 artiriq: {sum112}");
                int sum113 = sum112 - (sum112 * 18) / 100;
                Console.WriteLine($"bu ededden ozunun 18 faizini cixiriq: {sum113} ");

            }
            else
            {
                Console.WriteLine("daxil edilen eded sertleri odemir");
            }
            // task 12
            Console.WriteLine("5 reqemli ededi daxil edin: ");
            string sstr = Console.ReadLine();
            string s1str = Console.ReadLine();
            if (int.TryParse(sstr, out int s) && sstr.Length == 5 && int.TryParse(s1str, out int s1) && s1str.Length == 5)
            {
                int s2 = s % 10;
                int sum = 0;
                while (s > 0)
                {
                    sum += s % 10;
                    s /= 10;
                }
                int hasil = 1;
                while (s1 > 0)
                {
                    hasil *= s1 % 10;
                    s1 /= 10;
                }
                int result12 = sum + hasil;
                int result12m = result12 + s2;
                Console.WriteLine(result12m);


            }

            else
            {
                Console.WriteLine("daxil edilen eded sertleri odemir");
            }

            // Task 13
            Console.WriteLine("5 reqemli eded daxil edin");
            string tStr=Console.ReadLine();
            string t1Str=Console.ReadLine();    
            string t2Str=Console.ReadLine();
            if( int.TryParse(tStr,out int t) && tStr.Length ==5 && int.TryParse(t1Str, out int t1)&& t1Str.Length == 5 &&  int.TryParse(t2Str,out int t2) && t2Str.Length == 5)
            {
                int tf = t / 10000;
                int t1f= t1 / 10000;
                int t2f= t2 / 10000;
                int tl = t % 10;
                int t1l= t1 % 10;
                int t2l= t2 % 10;
                int tr = (tf * 10) + tl;
                int t1r = (t1f * 10) + t1l;
                int t2r = (t2f * 10) + t2l;
                int sum13=tr+t1r+t2r;
                int result13 = (sum13 * 50) / 100;
                int result13Main = sum13 + result13;
                Console.WriteLine(result13Main);
            }
            else
            {
                Console.WriteLine("Daxil edilen eded sertleri odemir");
            }
            
           


































































        }
    }
}

