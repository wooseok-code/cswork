using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test01_Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            // ttt

            while (true)
            {
                try
                {
                    WriteLine("두 개의 정수를 입력하세요 : ");
                    string str = ReadLine();
                    i = int.Parse(str.Split(' ')[0]);
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
