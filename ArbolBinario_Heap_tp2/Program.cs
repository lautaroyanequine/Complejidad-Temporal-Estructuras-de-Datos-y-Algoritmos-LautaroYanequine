/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 18/4/2022
 * Hora: 11:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace ArbolBinario_Heap
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArbolBinario<int> arbolBinarioA = new ArbolBinario<int>(1);

			ArbolBinario<int> hijoIzquierdo=new ArbolBinario<int>(2);
			hijoIzquierdo.agregarHijoIzquierdo(new ArbolBinario<int>(3));
			hijoIzquierdo.agregarHijoDerecho(new ArbolBinario<int>(4));
			
			ArbolBinario<int> hijoDerecho=new ArbolBinario<int>(5);
			hijoDerecho.agregarHijoIzquierdo(new ArbolBinario<int>(6));
			hijoDerecho.agregarHijoDerecho(new ArbolBinario<int>(7));
			
			arbolBinarioA.agregarHijoIzquierdo(hijoIzquierdo);
			arbolBinarioA.agregarHijoDerecho(hijoDerecho);
			Console.WriteLine("Recorrido Preorden: ");
			arbolBinarioA.preorden();
			Console.WriteLine(" ");
			Console.WriteLine("Recorrido por Inorden(Agregando el 8): ");
			arbolBinarioA.agregar(8);
			arbolBinarioA.inorden();
			Console.WriteLine(" ");
			Console.WriteLine("Recorrido por Postorden: ");
			arbolBinarioA.postorden();
			Console.WriteLine(" ");
		
			Console.WriteLine("Recorrido por niveles: ");
			arbolBinarioA.recorridoPorNiveles();
			Console.WriteLine(" ");
			
			Console.WriteLine("Contar hojas");
			Console.WriteLine(arbolBinarioA.contarHojas());
			Console.WriteLine(" " );
			Console.WriteLine("Recorrido entre niveles");
			arbolBinarioA.recorridoEntreNiveles(1,2);
			Console.WriteLine(" ");
			Console.WriteLine("Metodo Incluye(Valor 10):");
			Console.WriteLine(arbolBinarioA.incluye(10));
			Console.WriteLine("Metodo Incluye(Valor 2):");
			Console.WriteLine(arbolBinarioA.incluye(2));
			/*
			
			//Red Binaria Llena
			RedBinarialLlena RedBinarialLlenaA = new RedBinarialLlena(1);
			
			RedBinarialLlena hijoIzquierdoRB=new RedBinarialLlena(2);
			hijoIzquierdoRB.agregarHijoIzquierdo(new RedBinarialLlena(3));
			hijoIzquierdoRB.agregarHijoDerecho(new RedBinarialLlena(4));
			
			RedBinarialLlena hijoDerechoRB=new RedBinarialLlena(5);
			hijoDerechoRB.agregarHijoIzquierdo(new RedBinarialLlena(6));
			hijoDerechoRB.agregarHijoDerecho(new RedBinarialLlena(7));
			 
			RedBinarialLlenaA.agregarHijoIzquierdo(hijoIzquierdoRB);
			RedBinarialLlenaA.agregarHijoDerecho(hijoDerechoRB);
			Console.WriteLine("El retardo es de ");
			Console.WriteLine(RedBinarialLlenaA.retardoReenvio());
			
			Console.WriteLine("\n \n");
			Console.WriteLine("Punto 4. Profundidad de Arbol binario nivel 2 ");
			ProfundidadArbolBinario r= new ProfundidadArbolBinario(arbolBinarioA);
			Console.WriteLine(r.SumaElementosProfundiad(2));
			
			Console.WriteLine("\n \n");
			
			Console.WriteLine("Heap");
			Heap<int> heap= new Heap<int>(false);
			heap.Agregar(10);
			heap.Agregar(2);
			heap.Agregar(3);
			heap.Agregar(40);
			heap.Agregar(500);
			heap.Agregar(6);

			Console.WriteLine(heap.Eliminar());
			Console.WriteLine(heap.Eliminar());
			heap.Agregar(10);
			Console.WriteLine(heap.Eliminar());
			
			
			Console.WriteLine("\n \n");
			Console.WriteLine("Heap con Buildheap");
			List<int> arrayr = new List<int>{100,2,3,500};
			Heap<int> heap2= new Heap<int>(arrayr,true);
			Console.WriteLine(heap2.Tope());
			
			Console.WriteLine("\n \n");
			Console.WriteLine("Metodo Impresora");
			List<string> arrayst = new List<String>{"Hola","Como Estas","Todo Bien","jaj"};
			Heap<string> impresora = new Heap<string>(arrayst,true);
			impresora.Agregar("zzz");
			Console.WriteLine(impresora.Eliminar());
			*/
			Console.Write("Presione una tecla para concluir la ejecucion . . . ");
			Console.ReadKey(true);
			
			Console.WriteLine("Hello World!");
			
		
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}