/*
 * Creado por SharpDevelop.
 * Usuario: USUARIO
 * Fecha: 28/09/2021
 * Hora: 03:00 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace Hash
{
	/// <summary>
	/// Description of Hash.
	/// </summary>
	public class HashEmpleados
	{
		private int tamaño=23;
		public List<Empleado>[] arreglo;
	
		public HashEmpleados()
		{
			arreglo= new List<Empleado>[tamaño];
			for(int a=0;a <tamaño;a++)
			{
				arreglo[a]=new List<Empleado>();
			}
		}
		
		public ulong getHashEntry(string nombre,int dni){
			ulong hash = 5381;
			foreach (char c in nombre)
			hash = (hash * 7) + (ulong) c;
			hash = (hash * 7) + (ulong) dni;
			
			return  hash % 23;
		}
		
		public void guardarClave(Empleado e)
		{
			ulong indice=this.getHashEntry(e.Nombre,e.Dni);
			arreglo[indice].Add(e);
		}
		public bool verificarExistencia(string nombre,int dni)
		{
			ulong indice=this.getHashEntry(nombre,dni);
			
			
			
		
			
				for(int e=0; e<arreglo[indice].Count; e++)
				{
					if(arreglo[indice][e].Dni==dni)
						return true;
				}
			
			
		
			return false;
		}
		
		
		
		
		
		public void recorrido()
		{
			for(int i=0 ; i<tamaño;i++)
			{
				for(int e=0; e<arreglo[i].Count; e++)
				{
					Console.WriteLine(arreglo[i][e]);
				}
			}
		}
					
	}
}
