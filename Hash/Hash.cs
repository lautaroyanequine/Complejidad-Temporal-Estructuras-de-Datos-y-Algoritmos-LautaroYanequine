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
	public class Hash
	{
		private int tamaño=23;
		public List<string>[] arreglo;
	
		public Hash()
		{
			arreglo= new List<string>[tamaño];
			for(int a=0;a <tamaño;a++)
			{
				arreglo[a]=new List<string>();
			}
		}
		
		public ulong getHashEntry(string user, string passwd){
			ulong hash = 5381;
			foreach (char c in user)
			hash = (hash * 7) + (ulong) c;
			foreach (char c in passwd)
			hash = (hash * 7) + (ulong) c;
			return  hash % 23;
		}
		
		public void guardarClave(string user,string contra)
		{
			ulong indice=this.getHashEntry(user,contra);
			arreglo[indice].Add(user);
		}
		public bool verificarClave(string user,string contra)
		{
			ulong indice=this.getHashEntry(user,contra);
			bool existe=arreglo[indice].Contains(user);
			return existe;
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
