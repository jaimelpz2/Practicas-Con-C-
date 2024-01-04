using System;

namespace matrixes
{
    class Program
    {
        static void Main(string[] args)
        {
            metodos fun = new metodos();
            int opcion,n1,n2;
            int [,] matriz;
            int [,] matriz2;
            int [,] resultado;

            matriz = new int[0,0];
            matriz2 = new int[0,0];
            resultado = new int[0,0];

        

            do{
             

               Console.WriteLine("\n\nM E N U");
               Console.WriteLine("1-.crear Arreglos");
               Console.WriteLine("2-.Leer Arreglo");
               Console.WriteLine("3-.Sumar Arreglo");
               Console.WriteLine("4-.Restar Arreglo");
               Console.WriteLine("5-.Multiplicar Arreglos");
               Console.WriteLine("6-.salir");
               Console.WriteLine("\n\nElija su Opcion: ");
               opcion = Convert.ToInt32(Console.ReadLine());

               switch (opcion)
               {
                   
                   case 1:
                    Console.WriteLine("Introduzca el numero de filas: ");
                   n1=Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Introduzca el numero de columnas: ");
                   n2=Convert.ToInt32(Console.ReadLine());
                   matriz=fun.Arreglo(n1,n2);
                   matriz2=fun.Arreglo(n1,n2);
                  
                    break;

                    case 2:
                     Console.WriteLine("\nPrimer Arreglo");
                    fun.LeerAr(matriz);
                    Console.WriteLine("\nSegundo Arreglo");
                    fun.LeerAr(matriz2);
                    
                    break;
                    
                    case 3:
                    Console.WriteLine("\nPrimer Arreglo");
                    fun.LeerAr(matriz);
                    Console.WriteLine("\nSegundo Arreglo");
                    fun.LeerAr(matriz2);
                    Console.WriteLine("\nResultado");
                    resultado=fun.sumAr(matriz,matriz2);
                    fun.LeerAr(resultado);

                    break;

                    case 4:
                    Console.WriteLine("\nPrimer Arreglo");
                    fun.LeerAr(matriz);
                    Console.WriteLine("\nSegundo Arreglo");
                    fun.LeerAr(matriz2);
                    Console.WriteLine("\nResultado");
                    resultado=fun.resAr(matriz,matriz2);
                    fun.LeerAr(resultado);
                   
                    break;

                    case 5:
                    Console.WriteLine("\nPrimer Arreglo");
                    fun.LeerAr(matriz);
                    Console.WriteLine("\nSegundo Arreglo");
                    fun.LeerAr(matriz2);
                    Console.WriteLine("\nResultado");
                    resultado=fun.multAr(matriz,matriz2);
                    fun.LeerAr(resultado);
                   
                    break;

               }
               

           }while(opcion<6 && opcion >0);
        }
    }
}
