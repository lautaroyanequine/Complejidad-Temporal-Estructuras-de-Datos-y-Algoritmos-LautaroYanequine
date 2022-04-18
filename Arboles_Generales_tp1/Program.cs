/*
 * Created by SharpDevelop.
 * User: Lautaro
 * Date: 4/4/2022
 * Time: 13:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Arboles_Generales
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			
			
//			//Ejercicio de nivel
//			
//			
//			//Raiz
//			ArbolGeneral<int> arbol = new ArbolGeneral<int>(1);
//			
//			//Nivel 1
//			
//			ArbolGeneral<int> arbol2 = new ArbolGeneral<int>(2);
//			ArbolGeneral<int> arbol3 = new ArbolGeneral<int>(3);
//			ArbolGeneral<int> arbol4 = new ArbolGeneral<int>(4);
//			
//			
//			//Nivel 2
//			
//			ArbolGeneral<int> arbol5 = new ArbolGeneral<int>(1);
//			ArbolGeneral<int> arbol6 = new ArbolGeneral<int>(2);
//			ArbolGeneral<int> arbol7 = new ArbolGeneral<int>(3);
//			ArbolGeneral<int> arbol8 = new ArbolGeneral<int>(4);
//			ArbolGeneral<int> arbol9 = new ArbolGeneral<int>(4);
//			ArbolGeneral<int> arbol10 = new ArbolGeneral<int>(4);
//			arbol.agregarHijo(arbol2);
//			arbol.agregarHijo(arbol2);
//			arbol.agregarHijo(arbol3);
//			arbol.agregarHijo(arbol4);
//			
//			arbol2.agregarHijo(arbol5);
//			
//			arbol3.agregarHijo(arbol6);
//			arbol3.agregarHijo(arbol7);
//			
//			arbol4.agregarHijo(arbol8);
//			
//			arbol6.agregarHijo(arbol9);
			
			
			
			
//				Console.WriteLine(arbol.altura());
//			arbol.porNivelesConSeparacion();
//			Console.WriteLine("   ");
//			
//			Console.WriteLine(arbol.ancho());
//			
//			Console.WriteLine(arbol.nivel(arbol9));
			
//			Console.WriteLine(arbol.nivel(1));
			
			// EJERCICIO 5 DE CAÑERIA 		
			
			ArbolGeneral<float> arbol = new ArbolGeneral<float>(1);			
			//Nivel 1
			ArbolGeneral<float> arbol2 = new ArbolGeneral<float>(2);
				ArbolGeneral<float> arbol3 = new ArbolGeneral<float>(3);
			ArbolGeneral<float> arbol4 = new ArbolGeneral<float>(4);
			
			//Nivel 2
			
			ArbolGeneral<float> arbol5 = new ArbolGeneral<float>(1);
			ArbolGeneral<float> arbol6 = new ArbolGeneral<float>(2);
			ArbolGeneral<float> arbol7 = new ArbolGeneral<float>(3);
			ArbolGeneral<float> arbol8 = new ArbolGeneral<float>(4);
			ArbolGeneral<float> arbol9 = new ArbolGeneral<float>(4);
		
			
			//Nivel 1
			arbol.agregarHijo(arbol2);
			arbol.agregarHijo(arbol3);
			arbol.agregarHijo(arbol4);
			//Nivel 2
			arbol2.agregarHijo(arbol5);
			arbol3.agregarHijo(arbol6);
			arbol3.agregarHijo(arbol7);	
			arbol4.agregarHijo(arbol8);
			//nivel 3
			arbol6.agregarHijo(arbol9);

			
			RedAgua red = new RedAgua(arbol);
			
			Console.Write("Ingrese la cantidad de caudal que tiene la cañeria maestra: ");
			float caudal= float.Parse(Console.ReadLine());
			
			Console.WriteLine("El minimo caudal de la red con un caño maestro de {0} litros es de: {1} ",caudal,red.minimoCaudal(caudal));
			
			//Ejercicio Quadtree
			
			Quadtree quadtree = new Quadtree("blanco");
						
			Quadtree quadtree2 = new Quadtree("blanco");	
			
			Quadtree quadtree3 = new Quadtree("blanco");	
						
			Quadtree quadtree4 = new Quadtree("negro");
						
			Quadtree quadtree5 = new Quadtree("blanco");
						
			Quadtree quadtree6 = new Quadtree("blanco");			
						
			Quadtree quadtree7 = new Quadtree("blanco");
						
			Quadtree quadtree8 = new Quadtree("blanco");
						
			Quadtree quadtree9 = new Quadtree("negro");
						
			Quadtree quadtree10 = new Quadtree("negro");
						
			Quadtree quadtree11 = new Quadtree("negro");
						
			Quadtree quadtree12 = new Quadtree("blanco");
			Quadtree quadtree13 = new Quadtree("blanco");		

			
			quadtree.agregarHijo(quadtree2);
			quadtree.agregarHijo(quadtree3);
			quadtree.agregarHijo(quadtree4);
			quadtree.agregarHijo(quadtree5);
			quadtree2.agregarHijo(quadtree6);
			quadtree2.agregarHijo(quadtree7);
			quadtree2.agregarHijo(quadtree8);
			quadtree2.agregarHijo(quadtree9);
			quadtree3.agregarHijo(quadtree10);
			quadtree3.agregarHijo(quadtree11);
			quadtree3.agregarHijo(quadtree12);
			quadtree3.agregarHijo(quadtree13);
			
			Console.WriteLine(quadtree.retornaNegro());
			
			
			// Se puede mejorar el codigo
			
			
			
			
			
			
	
			
			
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}