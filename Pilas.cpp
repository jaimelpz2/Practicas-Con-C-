#include<iostream>
#include<conio.h>

using namespace std;

struct nodo{
	int dato;
	nodo *siguiente;
};

void agregarpila(nodo *&,int);
void sacarpila(nodo *&,int &);
void mostrarpila(nodo *&);

int main(){
	nodo *pila= NULL;
	int dato;
	int respuesta;
	
	do{
		cout<<"\ndigite un numero: ";
		cin>>dato;
		agregarpila(pila,dato);
		
		cout<<"\nDesea agregar otro elemento a pila(1/0): ";
		cin>>respuesta;
	}while(respuesta==1);
	
	cout<<"\nSacando todos los elementos de pila: ";
	while(pila!= NULL){
		sacarpila(pila,dato);
		if(pila != NULL){
			cout<<dato<<",";
		}else{
			cout<<dato;
		}
	}
	
	return 0;
}

void agregarpila(nodo *&pila,int n){
	nodo *nuevo_nodo=new nodo();
	nuevo_nodo->dato=n;
	nuevo_nodo->siguiente=pila;
	pila=nuevo_nodo;
	
	
	cout<<"\tElemento ["<<n<<"] ha sido agregado a pila correctamente";
}

void mostrarpila(nodo *&pila){
	
}

void sacarpila(nodo *&pila,int &n){
	nodo *aux=pila;
	n= aux->dato;
	pila=aux->siguiente;
	delete aux;
}
