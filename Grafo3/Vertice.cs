using System;
using System.Collections.Generic;

namespace EjercicioTopologico
{
	/// <summary>
	/// Description of Vertice.
	/// </summary>
	public class Vertice<T>
	{		
		private List<Arista<T>> adyacentes; 
    	private T dato;
    	private int posicion,grado;
	
		public Vertice(){}
		
	    public Vertice(T d){
			dato = d;
			adyacentes = new List<Arista<T>>();
			grado=0;
			
		}
    
		public void setDato(T unDato) {
			dato = unDato;
		}
	
		public T getDato() {
			return dato;
		}		

		public void setPosicion(int pos){
			posicion = pos; 
		}
		
		public int getPosicion() {
			return posicion;
		}
	
		public List<Arista<T>> getAdyacentes(){
			return adyacentes;
		}
		public void sumaGrado()
		{
			grado++;
		}
		public void eliminarGrado()
		{
			grado--;
		}
		public int Grado
		{
			get{return grado;}
		}
		
		public override string ToString()
		{
			return dato.ToString();
		}

	}
}
