using System;

namespace ABB_y_AVL
{

	public class ArbolBinarioBusqueda{
		
		private IComparable dato;
		private ArbolBinarioBusqueda hijoIzquierdo;
		private ArbolBinarioBusqueda hijoDerecho;
		
		
		public ArbolBinarioBusqueda(IComparable dato){
			this.dato = dato;
		}
		
		
		public IComparable getDatoRaiz(){
			return this.dato;
		}
		
		public ArbolBinarioBusqueda getHijoIzquierdo(){
			return this.hijoIzquierdo;
		}
		
		public ArbolBinarioBusqueda getHijoDerecho(){
			return this.hijoDerecho;
		}
		
		public void agregarHijoIzquierdo(ArbolBinarioBusqueda hijo){
			this.hijoIzquierdo=hijo;
		}

		public void agregarHijoDerecho(ArbolBinarioBusqueda hijo){
			this.hijoDerecho=hijo;
		}
		
		public void eliminarHijoIzquierdo(){
			this.hijoIzquierdo=null;
		}
		
		public void eliminarHijoDerecho(){
			this.hijoDerecho=null;
		}
		
		public void agregar(IComparable elem) {
			// comparo con raiz (dato)
			int comp = elem.CompareTo(this.dato);
			
			// si es menor, consulto si hijo izquierdo de raiz es null
			if(comp < 0){
				// si HI de raiz es null, inserto
				if(this.hijoIzquierdo == null)
					this.agregarHijoIzquierdo(new ArbolBinarioBusqueda(elem));
				// si no, llamada recursiva
				else
					this.hijoIzquierdo.agregar(elem);
			}
			// si es mayor o igual a la raiz
			else{
				if(this.hijoDerecho == null)
					this.agregarHijoDerecho(new ArbolBinarioBusqueda(elem));
				else
					this.hijoDerecho.agregar(elem);				
			}
		}
		
		public bool incluye(IComparable elem) {
			// comparamos con raiz 
			int auxiliar=elem.CompareTo(this.dato);
				// si son iguales retornamos true
			if(auxiliar==0)
				return true;
			else if(auxiliar<0)
			{
				if(this.hijoIzquierdo != null)
					return this.hijoIzquierdo.incluye(elem);
			}
			else
			{
				if(this.hijoDerecho != null)
					return this.hijoDerecho.incluye(elem);
			}
			
			
			return false;
		}


		public void preorden() {
			Console.Write(this.dato + " ");
			
			if(this.hijoIzquierdo != null)
				this.hijoIzquierdo.preorden();
			
			if(this.hijoDerecho != null)
				this.hijoDerecho.preorden();
		}
		
		public void inorden() {
			//Hijo izquierdo recursivamente
			if(this.hijoIzquierdo != null)
				this.hijoIzquierdo.inorden();
			//Raiz(dato)
			Console.Write(this.dato +" ");		
			//Hijo derecho recursivamente			
			if(this.hijoDerecho != null)
				this.hijoDerecho.inorden();
		}
		
		public void postorden() {
			if(this.hijoIzquierdo != null)
				this.hijoIzquierdo.postorden();
			
			if(this.hijoDerecho != null)
				this.hijoDerecho.postorden();
			
			Console.Write(this.dato + " ");
		}
		
	}
}