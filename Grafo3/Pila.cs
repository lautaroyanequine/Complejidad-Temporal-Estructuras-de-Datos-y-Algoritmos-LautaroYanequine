/*
 * Creado por SharpDevelop.
 * Usuario: USUARIO
 * Fecha: 23/10/2021
 * Hora: 04:31 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace EjercicioTopologico
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
		public class Pila <T>
	{
		private List<T> elementos = new List<T>();
		
		
		public void apilar(T elem)   
		{
			elementos.Add(elem);
		}
		public T desapilar()
		{
			T aux;
			int tam=elementos.Count;
			aux=(T)elementos[tam-1];
			elementos.Remove(aux);
			return aux;
		}
		public bool vacia()
		{
			return elementos.Count==0;
		}
		public T tope()
		{
			int tam=elementos.Count;
			return (T) elementos[tam-1];
		}
	}
	}

