/*
 * Creado por SharpDevelop.
 * Usuario: USUARIO
 * Fecha: 23/10/2021
 * Hora: 03:10 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Collections;

namespace EjercicioTopologico
{
	/// <summary>
	/// Description of OrdenacionTopologica.
	/// </summary>
	public class OrdenacionTopologica<T>
	{
		public OrdenacionTopologica()
		{
		}
		
		
		
		public void ordenarTopologicamente(Grafo<T> grafo){
			// creamos arreglo de visitados
			bool[] visitados = new bool[grafo.getVertices().Count];
			Pila <Vertice<T>> P= new Pila<Vertice<T>>();
			// llamamos a _DFS
			foreach(var v in grafo.getVertices())
			{
				if (v.Grado==0)
					this._ordenarTopologicamente(v, visitados,P);
			}
			
			while(!P.vacia())
			{
				Console.WriteLine(P.desapilar().getDato());
			}
		}
		
		private void _ordenarTopologicamente(Vertice<T> origen, bool[] visitados,Pila <Vertice<T>> P){

	
			// marcamos origen como vistado
			visitados[origen.getPosicion() - 1] = true;
			
			// procesamos origen
//			Console.Write(origen.getDato().ToString() + " ");
//			Console.WriteLine(origen.Grado);
			
			// llamada recursiva en adyacentes no visitados
			foreach(var adyacente in origen.getAdyacentes())
				if(!visitados[adyacente.getDestino().getPosicion() - 1])
					this._ordenarTopologicamente(adyacente.getDestino(), visitados,P);
			P.apilar(origen);
			 
			
		}
		
		public void ordenar(Grafo<T> grafo)
		{
			
		}
	}
}
