using System;

namespace C_{

    class calculadora{
        
       
       
        public int sumar(int n1,int n2){

       return n1 + n2; 
       } 

       public int restar(int n1,int n2){

       return n1 - n2; 
       } 

       public int dividir(int n1,int n2){

       return n1 / n2; 
       } 

       public int multiplicar(int n1,int n2){

       return n1 * n2; 
       }

       public bool numPar(int n1) {

           if(n1 % 2 ==0){
               return true;
           }else{
               return false;
           }

       }

        public bool numPrimo(int n1) {

           for(int i=2;i<n1;i++){
          if(n1%i==0){
              return false;
          }

      }
    return true;
        }

        public int Factorial(int n1){
            int fact=1;
             for (int i = 1; i <= n1; i++) {
            fact *= i;
        }

        return fact;
        }

        public bool Amigos(int n1,int n2){
             long suma=0;

            for(long i=1;i<n1;i++){
                if(n1%i==0){
                    suma=suma+i;
                }
            }

            if(suma==n2){
                suma=0;
                 for(long i=1;i<n2;i++){
                if(n2%i==0){
                    suma=suma+i;
                }
            }

            if(suma==n1){
                return true;
            }else{
                return false;
            }

            }
            else{
                return false;
            }
           }

        public int Potencia(int n1,int n2){
/*
        int x=1;
        for(int i=1;i<=n2;i++){
            x=x*n1;
        }
        return x;
        }
*/

     int x=(int) Math.Pow(n1,n2);

      return x; }


    }
}
