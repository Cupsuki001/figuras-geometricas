using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    internal class Class1
    {
        double l , an;

        public Class1() { }

        public Class1(double l , double an) 
        {
          this.l = l;
        }
        public void opc() 
        {
            Console.WriteLine("FIGURAS GEOMETRICAS");
            Console.WriteLine("1.op Cuadrado");
            Console.WriteLine("2.op Rectangulo");
            Console.WriteLine("3.op Triangulo");
            Console.WriteLine("salir con 0");
            Console.WriteLine("--------------------");
        }

        public double cuadr(double l) 
        {
            return l * l;
        }

        public double rect(double l , double an) 
        {
            return l * an;
        }

        public double trian(double l , double an) 
        {
            return l * an / 2;
        } 

        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.Write(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("////////////////////////////////////");
                    Console.WriteLine("No se aceptan letras", error.Message);
                    Console.WriteLine("////////////////////////////////////");
                   
                }
            } while (v == 0);
            return num;
        }

    }
}
