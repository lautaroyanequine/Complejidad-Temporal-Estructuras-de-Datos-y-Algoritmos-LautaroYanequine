/*
 * Creado por SharpDevelop.
 * Usuario: USUARIO
 * Fecha: 28/09/2021
 * Hora: 03:34 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Hash
{
	
	public class Empleado
	{
		private int numero,dni;
		private string nombre;
		
		public Empleado(string nombre,int dni,int numero)
		{
			this.numero=numero;
			this.dni=dni;
			this.nombre=nombre;
		}
		public int Dni
		{
			get{return dni;}
			
		}
		public int Numero
		{
			get{return numero;}
		}
		public string Nombre
		{
			get{return nombre;}
		}
		
		public override string ToString()
		{
			return string.Format("[Empleado Numero={0}, Dni={1}, Nombre={2}]", numero, dni, nombre);
		}

	}
}
