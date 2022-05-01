/*
 * Creado por SharpDevelop.
 * Usuario: USUARIO
 * Fecha: 28/09/2021
 * Hora: 03:33 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Hash
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			//Ejercicio practica
			
			Console.WriteLine("Hello World!");
			Hash hash= new Hash();
			hash.guardarClave("Federico","Y");
			Console.WriteLine(hash.verificarClave("Federico","Y"));
			hash.recorrido();
			
			*/
			// TODO: Implement Functionality Here
			
		
			
			
			Console.WriteLine("Ejercicio para entregar");
			
			
			Console.WriteLine("Hello World!");
			HashEmpleados h= new HashEmpleados();
			Console.WriteLine("Agregar 2 empleados: ");
			for(int i=0;i<2;i++)
			{
				Console.WriteLine("Ingrese nombre de empleado: ");
				string nombre = Console.ReadLine();
				Console.WriteLine("Ingrese dni de empleado: ");
				int dni = int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese numero de empleado: ");
				int numero = int.Parse(Console.ReadLine());
				Empleado e= new Empleado(nombre,dni,numero);
				h.guardarClave(e);
			}
			
			Console.WriteLine("Ingrese nombre de empleado: ");
				string nombree = Console.ReadLine();
				Console.WriteLine("Ingrese dni de empleado: ");
				int dnii = int.Parse(Console.ReadLine());
				
				Console.WriteLine(h.verificarExistencia(nombree,dnii));
				
				Console.WriteLine("Recorrido");
				h.recorrido();
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}