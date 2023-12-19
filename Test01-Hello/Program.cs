using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test01_Hello
{

    static class myLib
    {
        public static string GetToken(string str, int n, char ch)        // str: "1 2 3" "1,2,3" n번째
        {
            return str.Split(ch)[n];
        }
    }

    class Point
    {
        int x, y;

        public Point(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public double Dist(Point p1, Point p2)
        {
            return Sqrt(Pow((p1.x - p2.x), 2) + Pow((p1.y - p2.y), 2));
        }

        public double getArea(Point p1, Point p2)
        {
            return Sqrt((Pow((p1.x - p2.x) * (p1.y - p2.y), 2)));
        }

        public static double operator -(Point p1, Point p2)
        {
            return Sqrt(Pow((p1.x - p2.x), 2) + Pow((p1.y - p2.y), 2));
        }
        public static double operator *(Point p1, Point p2)
        {
            return Sqrt((Pow((p1.x - p2.x) * (p1.y - p2.y), 2)));
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            Point p1 = new Point(3, 4);
            Point p2 = new Point(6, 9);
            double dd = 0;
            dd = point.Dist(p1, p2);
            WriteLine($"distance : {dd:F2}\n");     // :F2 반올림하여 소수점 이하 두번째자리까지 출력
            dd = point.getArea(p1, p2);
            WriteLine($"Area : {dd:F2}\n");         // :F2 반올림하여 소수점 이하 두번째자리까지 출력

            /*          Program pgm = new Program();
                      int i = pgm.function();*/
            Test01 Sub = new Test01();
            Sub.MainFunc();
        }
        int function()
        {
            while (true)
            {

            }
            return 1;
        }
    }
    class Test01 // main class
    {
        public void MainFunc()
        {
            //var v = 100;
            int i = 10;
            int j = 20;
            double d = 1.5;
            double e = 3.1;
            Object o = i + 1;
            var v = i * 10;
            WriteLine($"i : {i}\nj : {j}\nd : {d}\ne : {e}\no : {o}");
            o = e + 0.5;

            int k = sizeof(int);
            WriteLine($"int size:{sizeof(int)}, double size:{sizeof(double)}");
            //v = d * 10;
            WriteLine($"i : {i}\nj : {j}\nd : {d}\ne : {e}\no : {o}");
            int[] arr = new int[100];

            // ttt
            // myLib my = new myLib(); // static으로 선언하면 쓰지않는다
            while (true)
            {
                try
                {
                    WriteLine("두 개의 정수를 입력하세요 : ");
                    string str = ReadLine();
                    i = int.Parse(myLib.GetToken(str,0,' '));   // static일경우
                    //i = int.Parse(my.GetToken(str,0,' '));
                    j = int.Parse(str.Split(' ')[1]);
                    
                    WriteLine($"Hello World({i},{j})");   // printf 함수와 동일 brace안 숫자대로 들어감


                    WriteLine("두 개의 실수를 입력하세요 : ");
                    str = ReadLine();


                    d = double.Parse(str.Split(' ')[0]);
                    e = double.Parse(str.Split(' ')[1]);

                    WriteLine($"Main Function({d},{e})!");   // $표시를 넣으면 직접넣을수 있음. 보간문자열 string interpolation
                    //string Rstr;
                    //Rstr = ReadLine();
                    //string str = "STX" + i.ToString() + "ETX" + Rstr;
                    //string str2 = $"STX{i,5}ETX"+Rstr;
                }
                catch (Exception e1)
                {
                    WriteLine(e1.Message);

                }
            }

            //WriteLine(str);
            //WriteLine(str2);

        }
    }
}
