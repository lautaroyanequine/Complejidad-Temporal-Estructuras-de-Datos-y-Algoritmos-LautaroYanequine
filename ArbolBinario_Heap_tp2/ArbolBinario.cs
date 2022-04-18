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
			return 0;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
		}
	}
}
