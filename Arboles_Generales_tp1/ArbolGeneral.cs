using System;
using System.Collections.Generic;

namespace Arboles_Generales
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
		public void setDatoRaiz(T dat){
			this.dato = dat;
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			return hijos;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Add(hijo);
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Remove(hijo);
		}
	
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
		
	
		public int altura() {
			
			if(this.esHoja())
				return 0;
			else{
				int altMax = -1;
				foreach(ArbolGeneral<T> hijo in this.hijos){
					if(hijo.altura() >altMax)
						altMax =hijo.altura();
					}
				return altMax + 1;
			}
		}
		
		
		//RECORRIDOS    - kAlgoritmos que nos permiten visitar cada nodo una vez

		public void preorden(){
			// primero procesamos raiz
			Console.Write(this.dato + " ");
			
			// luego los hijos recursivamente
			foreach(var hijo in this.hijos)
				hijo.preorden();
		}
		
		public void postorden(){
			// primero los hijos recursivamente
			foreach(var hijo in this.hijos)
				hijo.postorden();
			
			// luego procesamos raiz
			Console.Write(this.dato + " ");
		}
		
		public void inorden(){
			// primero hijo izquierdo recursivamente
			if(!this.esHoja())
				this.hijos[0].inorden();
			
			// luego raiz (caso base)
			Console.Write(this.dato + " ");
			
			// por ultimo, los restantes hijos recursivamente
			for(int i = 1; i <= this.hijos.Count - 1; i++)
				this.hijos[i].inorden();
		}
		
		public void porNiveles(){
			Cola<ArbolGeneral<T>> c = new Cola<ArbolGeneral<T>>();
			ArbolGeneral<T> arbolAux;
			
			c.encolar(this);
			while(!c.esVacia()){
				arbolAux = c.desencolar();
				
				//Proceso el dato
				Console.Write(arbolAux.dato + " ");
				
				foreach(var hijo in arbolAux.hijos)
					c.encolar(hijo);				
			}			
		}		
		
		public void porNivelesConSeparacion(){
			Cola<ArbolGeneral<T>> c = new Cola<ArbolGeneral<T>>();
			ArbolGeneral<T> arbolAux;
			
			int nivel = 0;
			
			c.encolar(this);
			c.encolar(null);
			
			Console.Write("Nivel " + nivel + ": ");
			
			while(!c.esVacia()){
				arbolAux = c.desencolar();
				
				if(arbolAux == null){
					if(!c.esVacia()){
						nivel++;
						Console.Write("\nNivel " + nivel + ": ");
						c.encolar(null);
					}						
				}
				else{
					Console.Write(arbolAux.dato + " ");
				
					foreach(var hijo in arbolAux.hijos)
						c.encolar(hijo);
				}
			}
		}		

		public int ancho(){
			Cola<ArbolGeneral<T>> c = new Cola<ArbolGeneral<T>>();
			ArbolGeneral<T> arbolAux;
			
			int anc= 0; //Lleva la cuenta del ancho del arbol
			int contNodos= 0 ; //Cuenta los Arboles_Generales porNiveles nivle
			
			c.encolar(this);
			c.encolar(null);
			
			
			while(!c.esVacia()){
				arbolAux = c.desencolar();
				
				if(arbolAux == null){
					
					//Me voy quedando con el ancho
					if(contNodos>anc)
						anc=contNodos;
					//reseteo contador
					
					contNodos=0;
					
					if(!c.esVacia()){
						
						c.encolar(null);
					}						
				}
				else{
					
					//Procesamos
					contNodos++;
				
					foreach(var hijo in arbolAux.hijos)
						c.encolar(hijo);
				}
			}
			return anc;
		}		

		public int nivel(ArbolGeneral<T> arbol ){
			Cola<ArbolGeneral<T>> c = new Cola<ArbolGeneral<T>>();
			ArbolGeneral<T> arbolAux;
			ArbolGeneral<T> arbolRecibido= arbol;
			
			int niv=0;
			
			c.encolar(this);
			c.encolar(null);
			
			
			while(!c.esVacia()){
				arbolAux = c.desencolar();
				
				if(arbolAux == null){
										
					niv++;
					
					if(!c.esVacia()){
						
						c.encolar(null);
					}						
				}
				else{
					
					if(arbolAux==arbolRecibido){
						return niv;
					}

				
					foreach(var hijo in arbolAux.hijos)
						c.encolar(hijo);
				}
			}
			return niv;
		}			


		//Consideraciones punto 6
		//Nodo raiz toda la canti de px
		//stringq diga q color es
		//Si no es hoja va a estar subdividido si o si en 4
		//El nodo es blanco o negro si es hoja o un nodo con 4 hijos
		//Los nodos de cada nivel representan el total divididio 4 elevado al nivel
		//Recorrido por nivel con separacion
		//Ver video 
	}
	
		
}