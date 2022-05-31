using System;
using System.Collections.Generic;

namespace EjercicioTopologico
{
	/// <summary>
	/// Description of PruebaGrafo.
	/// </summary>
	public class PruebaGrafo
	{	
		public static void Main(string[] args)
		{
		
			
			//Grafo de ciudades
			
			
			
			Grafo <string> gr = new Grafo <string>();
			Vertice <string> lp = new Vertice <string>("La Plata");
			gr.agregarVertice(lp);
			Vertice <string> pi = new Vertice <string>("Pilar");
			gr.agregarVertice(pi);
			Vertice <string> ta = new Vertice <string>("Tandil");
			gr.agregarVertice(ta);
			Vertice <string> ma = new Vertice <string>("Madariaga");
			gr.agregarVertice(ma);
			Vertice <string> le = new Vertice <string>("Lezama");
			gr.agregarVertice(le);
			Vertice <string> mda = new Vertice <string>("Mar de Ajo");
			gr.agregarVertice(mda);
			Vertice <string> mdq = new Vertice <string>("Mar del Plata");
			gr.agregarVertice(mdq);
			Vertice <string> vg = new Vertice <string>("Villa Gessel");
			gr.agregarVertice(vg);
			Vertice <string> pin = new Vertice <string>("Pinamar");
			gr.agregarVertice(pin);
			
			gr.conectar(lp, ta, 0);
			gr.conectar(ta, lp, 0);
			gr.conectar(lp, le, 0);
			gr.conectar(le, lp, 0);
			gr.conectar(le, pi, 0);
			gr.conectar(pi, le, 0);
			gr.conectar(le, mda, 0);
			gr.conectar(mda, le, 0);
			gr.conectar(ta, pi, 0);
			gr.conectar(pi, ta, 0);
			gr.conectar(ta, ma, 0);
			gr.conectar(ma, ta, 0);
			gr.conectar(mdq, ta, 0);
			gr.conectar(ta, mdq, 0);
			gr.conectar(pi, ma, 0);
			gr.conectar(ma, pi, 0);
			gr.conectar(pi, mda, 0);
			gr.conectar(mda, pi, 0);
			gr.conectar(mda, pin, 0);
			gr.conectar(pin, mda, 0);
			gr.conectar(mdq, vg, 0);
			gr.conectar(vg, mdq, 0);
			gr.conectar(pin, ma, 0);
			gr.conectar(ma, pin, 0);
			gr.conectar(pin, vg, 0);
			gr.conectar(vg, pin, 0);
			
			
			Console.WriteLine("*** Recorrido DFS desde La Plata ***");
			gr.DFS(lp);
			Console.WriteLine();Console.WriteLine();
			
			
			
			
			
			
			Console.WriteLine("*** Recorrido BFS desde La Plata ***");
			gr.BFS(lp);
			Console.WriteLine();Console.WriteLine();
			
			Console.WriteLine("*** Recorrido BFS desde Pilar ***");
			gr.BFS(pi);
			Console.WriteLine();Console.WriteLine();
			
			Recorrido<string> rec = new Recorrido<string>();
			Recorrido<string> r= new Recorrido <string>();
			List<Vertice<string>> camino=	r.mejorCaminoDFSCantNodos(gr,lp,pin);
		
			Console.WriteLine("*** Buscamos camino entre La Plata y Pinamar ***");
			List<Vertice<string>> camino3 = rec.caminoSimpleConDFS(gr, lp, pin);
			foreach(var vertice in camino3)
				Console.Write(vertice.getDato().ToString() + " ");
			Console.WriteLine();Console.WriteLine();
			
			Console.WriteLine("*** Buscamos camino entre La Plata y Villa Gessel ***");
			List<Vertice<string>> camino2 = rec.caminoSimpleConDFS(gr, lp, vg);
			foreach(var vertice in camino2)
			{
				Console.Write(vertice.getDato().ToString() + " ");
				Console.WriteLine(vertice.Grado);
			}
			Console.WriteLine();Console.WriteLine();
			
			Console.WriteLine("*** Buscamos camino entre La Plata y Villa Gessel ***");
			List<Vertice<string>> camino43 = rec.caminoSimpleConDFS(gr, lp, vg);
			foreach(var vertice in camino43)
				Console.Write(vertice.Grado+ " ");
			Console.WriteLine();Console.WriteLine();

			List<List<Vertice<string>>> todosLosCaminos=r.todosLosCaminosDFS(gr,lp,pin);
			Console.WriteLine("******Mejor Camino posible ******");
			foreach(var a in camino){
				Console.WriteLine(a);
			}
			
			Console.WriteLine();
			
			foreach(List<Vertice<string>> a in todosLosCaminos){
				Console.WriteLine("******Camino posible ******");
				foreach( Vertice<string> e in a){
					
					Console.WriteLine(e);
				}
				Console.WriteLine();
			}
			
			
			
			

			
			//Ejercicio LABERINTO
			
			/*
			Grafo <string> laberinto = new Grafo <string>();
			Vertice <string> nodoEntrada = new Vertice <string>("Nodo Entrada");
			laberinto.agregarVertice(nodoEntrada);
			Vertice <string> nodo1 = new Vertice <string>("Nodo 1");
			laberinto.agregarVertice(nodo1);
			Vertice <string> nodo2 = new Vertice <string>("Nodo 2");
			laberinto.agregarVertice(nodo2);
			Vertice <string> nodo3 = new Vertice <string>("Nodo 3");
			laberinto.agregarVertice(nodo3);
			Vertice <string> nodo4 = new Vertice <string>("Nodo 4");
			laberinto.agregarVertice(nodo4);
			Vertice <string> nodo5 = new Vertice <string>("Nodo 5");
			laberinto.agregarVertice(nodo5);
			Vertice <string> nodo6 = new Vertice <string>("Nodo 6");
			laberinto.agregarVertice(nodo6);
			Vertice <string> nodo7 = new Vertice <string>("Nodo 7");
			laberinto.agregarVertice(nodo7);
			Vertice <string> nodo8 = new Vertice <string>("Nodo 8");
			laberinto.agregarVertice(nodo8);

			Vertice <string> nodo9 = new Vertice <string>("Nodo 9");
			laberinto.agregarVertice(nodo9);
			Vertice <string> nodo10 = new Vertice <string>("Nodo 10");
			laberinto.agregarVertice(nodo10);
			Vertice <string> nodo11 = new Vertice <string>("Nodo 11");
			laberinto.agregarVertice(nodo11);
			Vertice <string> nodo12 = new Vertice <string>("Nodo 12");
			laberinto.agregarVertice(nodo12);
			Vertice <string> nodo13 = new Vertice <string>("Nodo 13");
			laberinto.agregarVertice(nodo13);
			Vertice <string> nodo14 = new Vertice <string>("Nodo 14");
			laberinto.agregarVertice(nodo14);
			Vertice <string> nodo15 = new Vertice <string>("Nodo 15");
			laberinto.agregarVertice(nodo15);
			Vertice <string> nodo16 = new Vertice <string>("Nodo 16");
			laberinto.agregarVertice(nodo16);
			Vertice <string> nodo17 = new Vertice <string>("Nodo 17");
			laberinto.agregarVertice(nodo17);
			Vertice <string> nodoSalida = new Vertice <string>("Nodo salida");
			laberinto.agregarVertice(nodoSalida);
			
			laberinto.conectar(nodoEntrada, nodo1, 0);
			laberinto.conectar(nodo1, nodoEntrada, 0);
			
			laberinto.conectar(nodo1, nodo2, 0);
			laberinto.conectar(nodo2, nodo1, 0);
			
			laberinto.conectar(nodo1, nodo3, 0);
			laberinto.conectar(nodo3, nodo1, 0);	
			
			laberinto.conectar(nodo3, nodo4, 0);
			laberinto.conectar(nodo4, nodo3, 0);
				
			laberinto.conectar(nodo4, nodo5, 0);
			laberinto.conectar(nodo5, nodo4, 0);
				
			laberinto.conectar(nodo5, nodo6, 0);
			laberinto.conectar(nodo6, nodo5, 0);
				
			laberinto.conectar(nodo3, nodo7, 0);
			laberinto.conectar(nodo7, nodo3, 0);
				
			laberinto.conectar(nodo7, nodo8, 0);
			laberinto.conectar(nodo8, nodo7, 0);
				
			laberinto.conectar(nodo8, nodo9, 0);
			laberinto.conectar(nodo9, nodo8, 0);
				
			laberinto.conectar(nodo7, nodo10, 0);
			laberinto.conectar(nodo10, nodo7, 0);
				
			laberinto.conectar(nodo10, nodo11, 0);
			laberinto.conectar(nodo11, nodo10, 0);
				
			laberinto.conectar(nodo11, nodo12, 0);
			laberinto.conectar(nodo12, nodo10, 0);
				
			laberinto.conectar(nodo12, nodo13, 0);
			laberinto.conectar(nodo13, nodo12, 0);
				
			laberinto.conectar(nodo10, nodo13, 0);
			laberinto.conectar(nodo13, nodo10, 0);
				
			laberinto.conectar(nodo13, nodo14, 0);
			laberinto.conectar(nodo14, nodo13, 0);
				
			laberinto.conectar(nodo14, nodoSalida, 0);
			laberinto.conectar(nodoSalida, nodo14, 0);
				
			laberinto.conectar(nodo14, nodo15, 0);
			laberinto.conectar(nodo15, nodo14, 0);
				
			laberinto.conectar(nodo15, nodo16, 0);
			laberinto.conectar(nodo16, nodo15, 0);
				
			laberinto.conectar(nodo16, nodo17, 0);
			laberinto.conectar(nodo17, nodo16, 0);
			
			Recorrido <string> rec= new Recorrido<string>();
			laberinto.BFS(nodoEntrada);
			rec.caminoSimpleConDFS(laberinto,nodoEntrada,nodoSalida);
			Console.WriteLine("");
			
			Console.WriteLine("*** Buscamos camino entre Entrada y Salida ***");
			List<Vertice<string>> camino = rec.caminoSimpleConDFS(laberinto,nodoEntrada,nodoSalida);
			foreach(var vertice in camino)
				Console.Write(vertice.getDato().ToString() + " ");
			Console.WriteLine();Console.WriteLine();
			
			Console.Write(" La cantidad minima de nodos que se tiene que pasar para salir del laberinto es de : ");
			Console.WriteLine(rec.mejorCaminoDFSCantNodos(laberinto,nodoEntrada,nodoSalida).Count);
			
			*/
			
			//Ejercicio de Museo realizado aparte

			//ORDEN TOPOLOGICO
			
//			
//			
//			Grafo <string> gr2 = new Grafo <string>();
//			Vertice <string> c1 = new Vertice <string>("C1");
//			gr2.agregarVertice(c1);
//			Vertice <string> c2 = new Vertice <string>("C2");
//			gr2.agregarVertice(c2);
//			Vertice <string> c3 = new Vertice <string>("C3");
//			gr2.agregarVertice(c3);
//			Vertice <string> c4 = new Vertice <string>("C4");
//			gr2.agregarVertice(c4);
//			Vertice <string> c5 = new Vertice <string>("C5");
//			gr2.agregarVertice(c5);
//			
//			gr2.conectar(c1, c3, 0);
//			gr2.conectar(c3, c5, 0);
//			gr2.conectar(c2, c3, 0);
//			gr2.conectar(c2, c4, 0);
//			gr2.conectar(c4, c5, 0);
//			
			
			/*
			
			
			//ropa
			Grafo <string> gr = new Grafo <string>();
			Vertice <string> boxer = new Vertice <string>("Boxer");
			gr.agregarVertice(boxer);
			Vertice <string> pantalones = new Vertice <string>("pantalones");
			gr.agregarVertice(pantalones);
			Vertice <string> cinturones = new Vertice <string>("cinturones");
			gr.agregarVertice(cinturones);
			Vertice <string> camisa = new Vertice <string>("Camisa");
			gr.agregarVertice(camisa);
			Vertice <string> corbata = new Vertice <string>("Corbata");
			gr.agregarVertice(corbata);
			Vertice <string> saco = new Vertice <string>("saco");
			gr.agregarVertice(saco);
			Vertice <string> media = new Vertice <string>("Media");
			gr.agregarVertice(media);
			Vertice <string> zapato = new Vertice <string>("Zapato");
			gr.agregarVertice(zapato);
			Vertice <string> reloj = new Vertice <string>("Reloj");
			gr.agregarVertice(reloj);
			
			gr.conectar(boxer, pantalones, 0);
			gr.conectar(pantalones, cinturones, 0);
			gr.conectar(cinturones, corbata, 0);
			gr.conectar(corbata, saco, 0);
			gr.conectar(camisa, cinturones, 0);
			gr.conectar(boxer, zapato, 0);
			gr.conectar(pantalones, zapato, 0);
			gr.conectar(media, zapato, 0);
			
			
//			Recorrido<string> rec = new Recorrido<string>();
//
//		
//			Console.WriteLine("*** Buscamos camino entre C1yC5 ***");
//			List<Vertice<string>> camino = rec.caminoSimpleConDFS(gr2, c1, c5);
//			foreach(var vertice in camino)
//			{
//				Console.Write(vertice.getDato().ToString() + " ");
//				Console.WriteLine(vertice.Grado);
//			}
//			Console.WriteLine();Console.WriteLine();
//			
//			gr.DFS(c2);
//			
			OrdenacionTopologica<string> or=new OrdenacionTopologica<string>();
			or.ordenarTopologicamente(gr);
			
				
//			
//			
			*/
			
			
			
			Console.Write("Presione una tecla para concluir la ejecucion . . . ");
			Console.ReadKey(true);
		}	
	}
}
