using System;
using System.Collections.Generic;

namespace EjercicioTopologico
{
	/// <summary>
	/// Description of Recorrido.
	/// </summary>
	public class Recorrido<T>
	{
		public Recorrido()
		{
		}
		
		public List<Vertice<T>> caminoSimpleConDFS(Grafo<T> grafo, Vertice<T> origen, Vertice<T> destino){
			// creamos arreglo de visitados
			bool[] visitados = new bool[grafo.getVertices().Count];
			
			// instanciamos lista de vertices (camino)
			List< Vertice<T>> camino = new List<Vertice<T>>();
			
			// se busca el camino con _caminoSimpleConDFS
			_caminoSimpleConDFS(grafo, origen, destino, camino, visitados);
			
			return camino;
		}
		
		private bool _caminoSimpleConDFS(Grafo<T>grafo,Vertice<T> origen,Vertice<T>destino,List<Vertice<T>> camino,bool[] visitados)
		{
			bool caminoHallado = false;
			
			// agrego origen a camino
			camino.Add(origen);
			
			// marco a origen como visitado
			visitados[origen.getPosicion() - 1] = true;
			
			if(origen == destino){
				caminoHallado = true;
			}
			else{
				foreach(var adyacente in origen.getAdyacentes()){
					if(!visitados[adyacente.getDestino().getPosicion() - 1]){
						caminoHallado = _caminoSimpleConDFS(grafo, adyacente.getDestino(), destino, camino, visitados);
						
						// si se encontro un camino, no seguimos buscando
						if(caminoHallado){
							break;
						}
						
						// si se formo un camino que no nos lleva al destino, sacamos ultimo vértice
						// y buscamos camino alternativo
						camino.RemoveAt(camino.Count - 1);
					}				
				}
			}
			
			return caminoHallado;
		}	

		public void verticeADistanciaConBFS(Grafo <T> grafo,Vertice<T> origen,int nroAristas) {
			Cola<Vertice<T>> c = new Cola<Vertice<T>>();
			Vertice<T> verticeAux;
			bool[] visitados = new bool[grafo.getVertices().Count];
			int distancia=0;
			
			// encolamos origen
			c.encolar(origen);
			c.encolar(null);
			// marcamos origen como visitado
			visitados[origen.getPosicion() - 1] = true;
			
			// procesamos cola
			while(!c.esVacia()){
				// desencolamos
				verticeAux = c.desencolar();
				
				if(verticeAux == null)
				{
					c.encolar(null);
					distancia++;
					
				}
				else
				{
					if(distancia <= nroAristas)
					{
						Console.Write(verticeAux.getDato().ToString() + " ");
				
						// encolamos adyacentes no visitados
						foreach(var adyacente in verticeAux.getAdyacentes()){
							if(!visitados[adyacente.getDestino().getPosicion() - 1]){
								c.encolar(adyacente.getDestino());
								// marcar a los elementos encolados como visitados
								visitados[adyacente.getDestino().getPosicion() - 1] = true;
							}
						}
					}
					
			
				}
				
		
			}				
		}		
		
		
		
		
		
		//Este metodo se puede usar para actividad de laberinto
		public List<Vertice<T>> mejorCaminoDFSCantNodos(Grafo<T> grafo, Vertice<T> origen, Vertice<T> destino){
			// creamos arreglo de visitados
			bool[] visitados = new bool[grafo.getVertices().Count];
			
			// instanciamos lista de vertices (camino)
			List<Vertice<T>> camino = new List<Vertice<T>>();
			List<Vertice<T>> mejorCamino = new List<Vertice<T>>();
			for(int i=0; i<grafo.getVertices().Count+10;i++)
			{
				mejorCamino.Add(null);
			}
	
			
			// se busca el camino con _caminoSimpleConDFS
			_mejorCaminoDFSCantNodos(grafo, origen, destino, camino, visitados,mejorCamino);
			
			return mejorCamino;
		}
		
		private void _mejorCaminoDFSCantNodos(Grafo<T>grafo,Vertice<T> origen,Vertice<T>destino,List<Vertice<T>> camino,bool[] visitados,List<Vertice<T>> mejorCamino)
		{
			
			// agrego origen a camino
			camino.Add(origen);
			
			// marco a origen como visitado
			visitados[origen.getPosicion() - 1] = true;
			
			if(origen == destino){
				if(camino.Count < mejorCamino.Count)
				{
							mejorCamino.Clear();
							foreach(Vertice<T> nodo in camino)
							{
								mejorCamino.Add(nodo);
							}
					}
			}
					
			else{
				foreach(var adyacente in origen.getAdyacentes()){
					if(!visitados[adyacente.getDestino().getPosicion() - 1]){
						 _mejorCaminoDFSCantNodos(grafo, adyacente.getDestino(), destino, camino, visitados,mejorCamino);
						
						// si se encontro un camino, no seguimos buscando
						
						
						// si se formo un camino que no nos lleva al destino, sacamos ultimo vértice
						// y buscamos camino alternativo
						visitados[adyacente.getDestino().getPosicion() - 1] = false;
						
						camino.RemoveAt(camino.Count - 1);
					}				
				}
			}
			
			
		}	
		
		
		public List<List<Vertice<T>>> todosLosCaminosDFS(Grafo<T> grafo, Vertice<T> origen, Vertice<T> destino){
			// creamos arreglo de visitados
			bool[] visitados = new bool[grafo.getVertices().Count];
			
			// instanciamos lista de vertices (camino)
			List<Vertice<T>> camino = new List<Vertice<T>>();
			List<List<Vertice<T>>> resultados = new List<List<Vertice<T>>>();

	
			
			// se busca el camino con _caminoSimpleConDFS
			_todosLosCaminosDFS(grafo, origen, destino, camino, visitados,resultados);
			
			return resultados;
		}
		
		private void _todosLosCaminosDFS(Grafo<T>grafo,Vertice<T> origen,Vertice<T>destino,List<Vertice<T>> camino,bool[] visitados,List<List<Vertice<T>>> resultados)
		{
			
			// agrego origen a camino
			camino.Add(origen);
			
			// marco a origen como visitado
			visitados[origen.getPosicion() - 1] = true;
			
			if(origen == destino){
				List<Vertice<T>> resultado=new List<Vertice<T>>();
				foreach( Vertice<T> a in camino){
					resultado.Add(a);
				}
				resultados.Add(resultado);
				
			}
					
			else{
				foreach(var adyacente in origen.getAdyacentes()){
					if(!visitados[adyacente.getDestino().getPosicion() - 1]){
						 _todosLosCaminosDFS(grafo, adyacente.getDestino(), destino, camino, visitados,resultados);
						
						
						// si se formo un camino que no nos lleva al destino, sacamos ultimo vértice
						// y buscamos camino alternativo
						visitados[adyacente.getDestino().getPosicion() - 1] = false;
						
						camino.RemoveAt(camino.Count - 1);
					}				
				}
			}
			
			
		}	
		
			
		
		
		
	}
}
