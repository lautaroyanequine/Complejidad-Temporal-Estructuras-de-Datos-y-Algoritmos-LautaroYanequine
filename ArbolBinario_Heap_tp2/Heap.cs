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
			int tamaño=datos.Count;
			for(int i=tamaño/2-1; i >= 0 ;i--)
			{
				FiltradoHaciaAbajo(i);
			}
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
			if(esMaxHeap)
			{
				for(int i = idx; i>0;i=(i-1)/2)
				{
					
					int auxiliar=datos[i].CompareTo(datos[(i-1)/2]);
					if(auxiliar>0)
					{
						Swap(i,(i-1)/2);
					}
					else
						break;
				}
			}
			else
			{
				for(int i = idx; i>0;i=(i-1)/2)
				{
					int auxiliar=datos[i].CompareTo(datos[(i-1)/2]);
					if(auxiliar<0)
					{
						Swap(i,(i-1)/2);
					}
					else
						break;
				}
			}
			
		}
		
		private void FiltradoHaciaAbajo(int idx){
			// implementar
			int longitud=datos.Count;
			if(esMaxHeap)
			{
				for(int i = idx; i<longitud;)
				{
					if(i*2+1 <= longitud && i*2+2 < longitud)   //Caso ideal que tenga los dos hijos
					{
						int auxiliar1=datos[i*2+1].CompareTo(datos[i*2+2]);   //A ver cual es mayor
						if(auxiliar1 >= 0)   //Si el primer hijo es mayor
						{
							int auxiliar2=datos[i].CompareTo(datos[i*2+1]);  //Lo comparo con la raiz
							if( auxiliar2 < 0 )    //Si es mayor el hijo
							{
								Swap(i*2+1,i);
								i=i*2+1;
							}
							else
								break;
						}
						else
						{
							int auxiliar2=datos[i].CompareTo(datos[i*2+2]);
							if( auxiliar2 < 0 )
							{
								Swap(i*2+2,i);
								i=i*2+2;
							}
							else
								break;
						}
						
					}
					else if (i*2+2 >=longitud && i*2+1 < longitud )  //Si solo existe hijo izquierdo
					{
						int auxiliar= datos[i].CompareTo(datos[i*2+1]);  
						if(auxiliar < 0)   
						{
							Swap(i*2+1,i);
								i=i*2+1;
						}
						else 
							break;
						
					}
					else                  //Si no tiene hijos
						break;
				}
			}
			else
			{
				for(int i = idx; i<longitud;)
				{
					if(i*2+1 <= longitud && i*2+2 < longitud)   //Caso ideal que tenga los dos hijos
					{
						int auxiliar1=datos[i*2+1].CompareTo(datos[i*2+2]);
						if(auxiliar1 <= 0)  //Si el hijo izquierdo es menor
						{
							int auxiliar2=datos[i].CompareTo(datos[i*2+1]);
							if( auxiliar2 > 0 ) //Si el hijo izquierdo es menor
							{
								Swap(i*2+1,i);
								i=i*2+1;
							}
							else
								break;
						}
						else
						{
							int auxiliar2=datos[i].CompareTo(datos[i*2+2]);
							if( auxiliar2 > 0 )
							{
								Swap(i*2+2,i);
								i=i*2+2;
							}
							else
								break;
						}
						
					}
					else if (i*2+2 >= longitud && i*2+1 < longitud )  //Si solo existe hijo izquierdo
					{
						int auxiliar= datos[i].CompareTo(datos[i*2+1]);
						if(auxiliar > 0)
						{
							Swap(i*2+1,i);
								i=i*2+1;
						}
						else 
							break;
						
					}
					else                  //Si no tiene hijos
						break;
				}
			}
		}
		
		private void Swap(int idx1, int idx2){
			T aux = this.datos[idx1];
			this.datos[idx1] = this.datos[idx2];
			this.datos[idx2] = aux;
		}
	}
	
}