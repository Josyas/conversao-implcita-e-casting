using System;

namespace conversao_implcita_e_casting {
    class Program {
        static void Main(string[] args) {

            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);
            //Conversão implicíta

            Console.WriteLine("=============================");
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);
            //Cast

            Console.WriteLine("===============================");   

            double c;
            int e;

            c = 5.1;
            e = (int)a;
            Console.WriteLine(e);
            //Cast

            Console.WriteLine("=================================");




        }
    }
}
