using System;

namespace C_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            calculadora cal = new calculadora();
            int opcion,n1,n2;
           do{
             

               Console.WriteLine("\n\nM E N U");
               Console.WriteLine("1-.Sumar");
               Console.WriteLine("2-.Restar");
               Console.WriteLine("3-.Multiplicar");
               Console.WriteLine("4-.Dividir");
               Console.WriteLine("5-.Numero Par");
               Console.WriteLine("6-.Numero Primo");
               Console.WriteLine("7-.Factorial");
               Console.WriteLine("8-.Numeros Amigos");
               Console.WriteLine("9-.Potencia");
               Console.WriteLine("0-.salir");
               Console.WriteLine("\n\nElija su Opcion: ");
               opcion = Convert.ToInt32(Console.ReadLine());
              
               switch (opcion)
               {
                   
                   case 1:
                    
                   Console.WriteLine("Introduzca el primer numero: ");
                   n1=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Introduzca el segundo numero: ");
                   n2=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("la suma es "+ cal.sumar(n1,n2));
                    break;

                    case 2:
                  Console.WriteLine("Introduzca el primer numero: ");
                   n1=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Introduzca el segundo  numero: ");
                   n2=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("la resta es "+ cal.restar(n1,n2));
                    break;

                    case 3:
                   Console.WriteLine("Introduzca el primer numero: ");
                   n1=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Introduzca el segundo  numero: ");
                   n2=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("la multiplicacion es "+ cal.multiplicar(n1,n2));
                    break;

                    case 4:
                   Console.WriteLine("Introduzca el primer numero: ");
                   n1=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Introduzca el segundo  numero: ");
                   n2=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("la division es "+ cal.dividir(n1,n2));
                    break;

                    case 5:
                   Console.WriteLine("Introduzca el numero para determinar si es par: ");
                   n1=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("El numero sera par?: "+ cal.numPar(n1));
                    break;
                    
                    case 6:
                   Console.WriteLine("Introduzca el numero para determinar si es primo: ");
                   n1=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("El numero sera primo?: "+ cal.numPrimo(n1));
                    break;
                    case 7:
                    Console.WriteLine("Introduzca el numero para determinar su factorial: ");
                   n1=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("El factorial es: "+ cal.Factorial(n1));
                    break;
                    case 8:
                     Console.WriteLine("Introduzca el primer numero para saber si es amigo: ");
                   n1=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("tu numero es amigo con este?: ");
                   n2=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("los numeros son : "+ cal.Amigos(n1,n2));
                    break;
                    case 9:
                    Console.WriteLine("Introduzca el numero para determinar su potencia: ");
                   n1=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("a la potencia?: ");
                   n2=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("El numero elevado es: "+ cal.Potencia(n1,n2));
                   //Console.WriteLine("El numero : "+n1+ " a la : "+n2+ " es: "+Math.Pow(n1,n2));
                    break;
               }
               

           }while(opcion<10 && opcion >0);
        }
    }
}
