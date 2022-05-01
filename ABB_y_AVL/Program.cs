/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 25/4/2022
 * Hora: 11:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ABB_y_AVL
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Arboles binarios de busqueda");
			
			int[] valores = new int[]{1, 4, 6, 8, 2, 5, 7};

			
			
			ArbolBinarioBusqueda abb = new ArbolBinarioBusqueda(3);
			foreach(var valor in valores)
				abb.agregar(valor);
			
			Console.WriteLine("*** Recorrido preorden ***");
			abb.preorden();
			Console.WriteLine();Console.WriteLine();
			
			Console.WriteLine("*** Recorrido postorden ***");
			abb.postorden();
			Console.WriteLine();Console.WriteLine();
		
			Console.WriteLine("Recorrido inorden");
			abb.inorden();
			Console.WriteLine("");
			
			Console.WriteLine("Metodo Inlcuye.Ingrese el numero");
			int a= int.Parse((Console.ReadLine()));
			Console.WriteLine(abb.incluye(a));
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}