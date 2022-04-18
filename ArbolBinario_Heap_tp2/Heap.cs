using System;
using System.Collections.Generic;

namespace ArbolBinario_Heap
{
	// Si la raiz se almacena en la posicion 0, y dado un elemento en la posicion i:
	//	- el hijo izquierdo esta en 2*i + 1
	//	- el hijo derecho esta en 2*i + 2
	//  - el padre esta en (i-1)/2
	
	public class Heap<T> where T : IComparable<T>
	{
		private List<T> datos;
		private bool esMaxHeap;
				
		public Heap(bool esMaxHeap){
			this.datos 		= new List<T>();
			this.esMaxHeap 	= esMaxHeap;
		}
		
		public Heap(List<T> datos, bool esMaxHeap)
		{
			this.datos 		= datos;
			this.esMaxHeap 	= esMaxHeap;
			
			// Implementar BuilHeap
		}
		
		public void Agregar(T elemento){
			// Primero ponemos elemento luego del ultimo elemento en heap
			this.datos.Add(elemento);
			
			// Luego se filtra hacia arriba
			this.FiltradoHaciaArriba(this.datos.Count - 1);
		}
		
		public T Eliminar(){
			// Primero guardamos elemento de la raiz en un auxiliar
			T aux = this.datos[0];
			
			// Pongo ultimo elemento en raiz
			this.datos[0] = this.datos[this.datos.Count - 1];
			this.datos.RemoveAt(this.datos.Count - 1);
			
			// Filtramos hacia abajo
			this.FiltradoHaciaAbajo(0);
			
			return aux;
			
		}
		
		public T Tope(){
			return this.datos[0];
		}
		
		public bool EsVacia(){
			return this.datos.Count == 0;
		}
		
		private void FiltradoHaciaArriba(int idx){
			// implementar
		}
		
		private void FiltradoHaciaAbajo(int idx){
			// implementar
		}
		
		private void Swap(int idx1, int idx2){
			T aux = this.datos[idx1];
			this.datos[idx1] = this.datos[idx2];
			this.datos[idx2] = aux;
		}
	}
	
}