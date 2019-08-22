using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //int MenuPrincipal;

            //double num1, num2;
            //do
            //{

            //    Console.Clear();
            //    Console.WriteLine("*****************");
            //    Console.WriteLine("   Calculadora   ");
            //    Console.WriteLine("      1.Suma     ");
            //    Console.WriteLine("      2.Resta    ");
            //    Console.WriteLine(" 3.Multiplicación");
            //    Console.WriteLine("    4.Potencia   ");
            //    Console.WriteLine("    5.División   ");
            //    Console.WriteLine("      6.Raíz     ");
            //    Console.WriteLine("      7.Salir    ");
            //    Console.WriteLine("*****************");
            //    MenuPrincipal = Convert.ToInt32(Console.ReadLine());


            //    switch (MenuPrincipal)
            //    {
            //        case 1:
            //            Console.WriteLine("Introduce el primer numero: ");
            //            num1 = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Introduce el segundo numero: ");
            //            num2 = Convert.ToDouble(Console.ReadLine());
            //            num1 += num2;
            //            break;
            //        case 2:
            //            Console.WriteLine("Introduce el primer numero: ");
            //            num1 = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Introduce el segundo numero: ");
            //            num2 = Convert.ToDouble(Console.ReadLine());
            //            num1 -= num2;
            //            break;
            //        case 3:
            //            Console.WriteLine("Introduce el primer numero: ");
            //            num1 = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Introduce el segundo numero: ");
            //            num2 = Convert.ToDouble(Console.ReadLine());
            //            num1 *= num2;
            //            break;
            //        case 4:
            //            Console.WriteLine("Introduce el primer numero: ");
            //            num1 = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Introduce el segundo numero: ");
            //            num2 = Convert.ToDouble(Console.ReadLine());
            //            num1 = Math.Pow(num1,num2);
            //            break;
            //        case 5:
            //            Console.WriteLine("Introduce el primer numero: ");
            //            num1 = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Introduce el segundo numero: ");
            //            num2 = Convert.ToDouble(Console.ReadLine());
            //            num1 /= num2;
            //            break;
            //        case 6:
            //            Console.WriteLine("Introduce el primer numero: ");
            //            num1 = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Introduce el segundo numero: ");
            //            num2 = Convert.ToDouble(Console.ReadLine());
            //            num1 = Math.Pow(num1, 1 / num2);
            //            break;
            //    }

            //} while (MenuPrincipal != 7);



            int MenuPrincipal;

            double num1, num2;
            do
            {

                Console.Clear();
                Console.WriteLine("*****************");
                Console.WriteLine("   Calculadora   ");
                Console.WriteLine("      1.Suma     ");
                Console.WriteLine("      2.Resta    ");
                Console.WriteLine(" 3.Multiplicación");
                Console.WriteLine("    4.Potencia   ");
                Console.WriteLine("    5.División   ");
                Console.WriteLine("      6.Raíz     ");
                Console.WriteLine("      7.Salir    ");
                Console.WriteLine("*****************");

                MenuPrincipal = Convert.ToInt32(Console.ReadLine());

                if (MenuPrincipal > 0 && MenuPrincipal < 7)
                {
                    Console.WriteLine("Introduce el primer numero: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduce el segundo numero: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    switch (MenuPrincipal)
                    {
                        case 1:
                            num1 += num2;
                            break;
                        case 2:
                            num1 -= num2;
                            break;
                        case 3:
                            num1 *= num2;
                            break;
                        case 4:
                            num1 = Math.Pow(num1, num2);
                            break;
                        case 5:
                            num1 /= num2;
                            break;
                        case 6:
                            num1 = Math.Pow(num1, 1 / num2);
                            break;
                    }
                    Console.WriteLine("el resultado es: " + num1);
                }
                else if (MenuPrincipal == 7)
                {

                }
                else
                {
                    Console.WriteLine("Opción " + MenuPrincipal + " no disponible, vuelva a intentarlo");
                }
                //Console.WriteLine("pulse una tecla para continuar");
                //Console.ReadKey();
            } while (MenuPrincipal != 7);
           

        }
    }
}
