using System;

namespace ArbolBinario_Heap
{
	public class ArbolBinario<T>
	{
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo = hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho = hijo;
		}
	
 		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo = null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho = null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo == null && this.hijoDerecho == null;
		}
		
		public bool incluye (T generico)
		{
			Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();
			ArbolBinario<T> arbolAux;
			c.encolar(this);
			bool existe=false;
			while(!c.esVacia())
			{
				arbolAux=c.desencolar();
				if(arbolAux.dato.Equals(generico))
					existe=true;
				
				if(arbolAux.hijoIzquierdo != null)
					c.encolar(arbolAux.hijoIzquierdo);
			
				if(arbolAux.hijoDerecho != null)
					c.encolar(arbolAux.hijoDerecho);
			}
			return existe;
			/*
					{
			bool existe=false;
			
			il
			
				//Hijo izquierdo recursivamente
				if(this.hijoIzquierdo != null)
					this.hijoIzquierdo.preorden();	
				//Hijo derecho recursivamente			
				if(this.hijoDerecho != null)
					this.hijoDerecho.preorden();
				//Raiz(dato)
				
			return existe;
		}*/
		}
		
		public void agregar(T generico)
		{
			ArbolBinario<T> aux= new ArbolBinario<T>(generico);
			if(this.hijoIzquierdo == null)
				this.agregarHijoIzquierdo(aux);
			else if (this.hijoDerecho == null)
				this.agregarHijoDerecho(aux);
			else
			{
				Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();
				ArbolBinario<T> arbolAux;
				c.encolar(this);
				while(!c.esVacia())
				{
					arbolAux=c.desencolar();
					if(arbolAux.hijoIzquierdo == null)
					{
						arbolAux.agregarHijoIzquierdo(aux);
						break;
					}
					else if(arbolAux.hijoDerecho == null)
					{
						arbolAux.agregarHijoDerecho(aux);
						break;
					}
					
					else
					{
					if(arbolAux.hijoIzquierdo != null)
						c.encolar(arbolAux.hijoIzquierdo);
				
					if(arbolAux.hijoDerecho != null)
						c.encolar(arbolAux.hijoDerecho);
					}
				}
			}
		}
		
		public void inorden() {
			if(this.hijoIzquierdo != null)
				this.hijoIzquierdo.inorden();
			
			Console.Write(this.dato + " ");
			
			if(this.hijoDerecho != null)
				this.hijoDerecho.inorden();
		}
		
		public void preorden() {
			Console.Write(this.dato + " ");
			
			if(this.hijoIzquierdo != null)
				this.hijoIzquierdo.preorden();
			
			if(this.hijoDerecho != null)
				this.hijoDerecho.preorden();
		}
		
		public void postorden() {
			if(this.hijoIzquierdo != null)
				this.hijoIzquierdo.postorden();
			
			if(this.hijoDerecho != null)
				this.hijoDerecho.postorden();
			
			Console.Write(this.dato + " ");
		}
		
		public void recorridoPorNiveles() {
			Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();
			ArbolBinario<T> arbolAux;
			
			c.encolar(this);
			while(!c.esVacia()){
				arbolAux = c.desencolar();
				
				Console.Write(arbolAux.dato + " ");
				
				if(arbolAux.hijoIzquierdo != null)
					c.encolar(arbolAux.hijoIzquierdo);
				
				if(arbolAux.hijoDerecho != null)
					c.encolar(arbolAux.hijoDerecho);
			}			
		}
	
		public int contarHojas() {
			//Con Inorden
			int cont=0;
			
				if(this.hijoIzquierdo != null)
				cont+=this.hijoIzquierdo.contarHojas();
				
				if(this.esHoja())
				{
					return 1;
				}
			
			if(this.hijoDerecho != null)
			cont+=	this.hijoDerecho.contarHojas();
			
			return cont;
			
			/* Por Niveles
		Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();
			ArbolBinario<T> arbolAux;
			int contador=0;
			c.encolar(this);
			while(!c.esVacia())
			{
				arbolAux=c.desencolar();
				if(arbolAux.esHoja())
					contador++;
				
				if(arbolAux.hijoIzquierdo != null)
					c.encolar(arbolAux.hijoIzquierdo);
			
				if(arbolAux.hijoDerecho != null)
					c.encolar(arbolAux.hijoDerecho);
				
			}
			return contador;
		*/
		}
		
		public void recorridoEntreNiveles(int n,int m) {
					//Se puede mejorar que no muestre "Nivel 0 =  "" 
				Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();
				ArbolBinario<T> arbolAux;
				int nivel = 0;
				
				c.encolar(this); //encolamos arbol
				c.encolar(null); // encolamos separador			
				Console.Write("Nivel " + nivel + ": ");
			
				while(!c.esVacia())
				{
					arbolAux = c.desencolar();
					
					if(arbolAux == null)
					{
						if(!c.esVacia())
						{
							nivel++;
							if(nivel>m )
								break;
							else{
								Console.Write("\nNivel " + nivel + ": ");
								c.encolar(null);
							}
						}						
					}
					else
					{
						if(nivel >= n && nivel <=m)
							Console.Write(arbolAux.dato + " ");
					
					
						if(arbolAux.hijoIzquierdo != null)
							c.encolar(arbolAux.hijoIzquierdo);
			
						if(arbolAux.hijoDerecho != null)
							c.encolar(arbolAux.hijoDerecho);
					}
				}
			
			
		}
	}
}
