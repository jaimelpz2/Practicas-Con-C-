#include<iostream>
#include<conio.h>
#include<stdlib.h>	

using namespace std;

struct nodo{
int dato;
nodo *siguiente;
};

void insertarcola(nodo *&,nodo *&,int n);
bool colavacia(nodo *&);
void eliminarcola(nodo *&,nodo *&,int &);



int main(){
nodo *frente = NULL;
nodo *fin = NULL;

int dato;

cout<<"\nintroduzca un numero: ";
cin>>dato;
insertarcola(frente,fin,dato);
cout<<"\nintroduzca un numero: ";
cin>>dato;
insertarcola(frente,fin,dato);
cout<<"\nintroduzca un numero: ";
cin>>dato;
insertarcola(frente,fin,dato);


cout<<"\n\nquitando los nodos de la cola: ";
while(frente != NULL){
	eliminarcola(frente,fin,dato);
	
	if(frente != NULL){
		cout<<dato<<",";
	}else{
		cout<<dato<<".";
	}
	
}


}

void insertarcola(nodo *&frente,nodo *&fin,int n){
nodo *nuevo_nodo=new nodo();

nuevo_nodo -> dato=n;
nuevo_nodo->siguiente=NULL;

if(colavacia(frente)){
frente=nuevo_nodo;
}else{
fin ->siguiente =nuevo_nodo;
}
fin = nuevo_nodo;

cout<<"\nElemento: "<<n<<"\tInsertado exitosamente";
}

void eliminarcola(nodo *&frente,nodo *&fin,int &n){
n = frente -> dato;
nodo *aux = frente;

if(frente==fin){
frente=NULL;
fin=NULL;
}else{
frente= frente->siguiente;
}
delete aux;

}



bool colavacia(nodo *&frente){
return (frente ==NULL)? true : false;
/*
if(frente == NULL){
return true;
}else{
return false;
}*/
}
