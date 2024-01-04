using System;

namespace matrixes{

    class metodos{

        int [,] matriz;

        int [,] resultado;

        Random random = new Random();

        public int[,] Arreglo(int n1,int n2){
             matriz = new int[n1,n2];
            for(int i=0;i<n1;i++){
                for(int j=0;j<n2;j++){
                    matriz[i,j]=random.Next(1,10);
                    
                }
                Console.WriteLine("");
            }
       return matriz; }

        

        public void LeerAr(int[,] matriz){
             
            for(int i=0;i<matriz.GetLength(0);i++){
                for(int j=0;j<matriz.GetLength(1);j++){
                    Console.Write(" " + matriz[i,j]);
                    
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

       
        public int[,] sumAr(int [,] matriz,int [,] matriz2){
            
        
            resultado=new int[matriz.GetLength(0),matriz.GetLength(1)];
    

            for(int i=0;i<matriz.GetLength(0);i++){
            for(int j=0;j<matriz.GetLength(1);j++){
                resultado[i,j]=matriz[i,j]+matriz2[i,j];
                
            }
                    
                }
                Console.ReadKey();


                        return resultado;
             
       }
        
        public int[,] resAr(int [,] matriz,int [,] matriz2){
            
                    resultado=new int[matriz.GetLength(0),matriz.GetLength(1)];

                for(int i=0;i<matriz.GetLength(0);i++){
                for(int j=0;j<matriz.GetLength(1);j++){
                    resultado[i,j]=matriz[i,j]-matriz2[i,j];
                    
                }
            }
            Console.ReadKey();
     
                return resultado;
        
        }

        public int[,] multAr(int [,] matriz,int [,] matriz2){
            if(matriz.GetLength(1)==matriz2.GetLength(0)){
                for(int i=0;i<matriz.GetLength(0);i++){
                     for(int j=0;j<matriz2.GetLength(1);j++){
                         resultado[i,j]=0;// este es pa que no de problemas ya me tiene arto 
                         for(int k=0;k<matriz.GetLength(0);k++){
                            resultado[i,j] +=(matriz[i,k]*matriz2[k,j]) ;
                    
                }

                 }
               
            }
            Console.ReadKey();

            return resultado;
            }else{
                Console.WriteLine("No se pueden Multiplicar por que las filas y  columnas no coinciden\n\n");
                return null;
            }
                

         }
    

    }
}