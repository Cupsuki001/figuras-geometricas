// See https://aka.ms/new-console-template for more information
using geometria;

public class figura 
{
  public static void Main(string [] args) 
  {
        Class1 f = new Class1();
        int op , op1;
        double l , ta , an;

        do 
        {
            do
            {
                Console.WriteLine("//////////////////////");
                f.opc();
                op = f.validar("Seleccione una opcion: ");
                Console.WriteLine("//////////////////////");

            } while (op < 0 || op > 3);

            switch (op) 
            {
               case 1: 
                    {
                        do
                        {
                            Console.WriteLine("-----------------------------");
                            l = f.validar("Ingrese el lado del cuadrado: ");
                            Console.WriteLine("//////////////////////");

                        } while (l <= 0);
                        ta = f.cuadr(l);
                        Console.WriteLine("El area del cuadrado es de :" + ta);
                    }
                    break;
                case 2:
                    {
                        do
                        {
                            Console.WriteLine("-----------------------------");
                            l = f.validar("Ingrese el largo: ");
                            an = f.validar("Ingrese el ancho: ");
                            Console.WriteLine("//////////////////////");

                        } while (l <= 0 || an <= 0);
                        ta = f.rect(l , an);
                        Console.WriteLine("El area del rectangulo es de :" + ta);
                    }
                    break;
                case 3:
                    {
                        do
                        {
                            Console.WriteLine("-----------------------------");
                            l = f.validar("Ingrese la base: ");
                            an = f.validar("Ingrese la altura: ");
                            Console.WriteLine("//////////////////////");

                        } while (l <= 0 || an <= 0);
                        ta = f.trian(l, an);
                        Console.WriteLine("El area del triangulo es de :" + ta);
                    }
                    break;
                default: 
                    {
                        Console.WriteLine("buen dia");
                    }
                    break;


                   
            }


        } while (op == 4);
       
  }
}
