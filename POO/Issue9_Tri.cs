using System;

namespace POO_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f;
            Triangulo t1;
            Triangulo t2;
            Console.WriteLine("Escreva lado 1 do triangulo A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva lado 2 do triangulo A:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva lado 3 do triangulo A:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva lado 1 do triangulo B:");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva lado 2 do triangulo B:");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva lado 3 do triangulo B:");
            f = Convert.ToDouble(Console.ReadLine());


            t1 = new Triangulo(a,b,c);
            t2 = new Triangulo(d,e,f);

            Console.WriteLine("Lados do Triángulo t1");
            Console.WriteLine(t1.ToString());

            Console.WriteLine("Lados do Triángulo t2");
            Console.WriteLine(t2.ToString());
        }

    }

}
