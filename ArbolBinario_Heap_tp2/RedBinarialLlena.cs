/*
 * Creado por SharpDevelop.
 * Usuario: USUARIO
 * Fecha: 16/09/2021
 * Hora: 03:45 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ArbolBinario_Heap
{
	/// <summary>
	/// Description of RedBinarialLlena.
	/// </summary>
	public class RedBinarialLlena
	{
		
		private int dato;
		private RedBinarialLlena hijoIzquierdo;
		private RedBinarialLlena hijoDerecho;
	
		
		public RedBinarialLlena(int dato) {
			this.dato = dato;
		}
	
		public int getDatoRaiz() {
			return this.dato;
		}
	
		public RedBinarialLlena getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public RedBinarialLlena getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(RedBinarialLlena  hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(RedBinarialLlena  hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}		
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		public int retardoReenvio()
		{
			if(this.esHoja())     //Cuando llegue a la hoja retorna el dato
			{
				
				return dato;
			}
			else
			{
				int retardo=0; // variable para calcular el retardo max
			
				if(hijoIzquierdo != null && hijoDerecho != null)   //Verificamos para hacer la comparacion
				{
					if(hijoIzquierdo.retardoReenvio() > hijoDerecho.retardoReenvio())
						retardo=hijoIzquierdo.retardoReenvio();
					else
					{
						 retardo=hijoDerecho.retardoReenvio();
					}
					
				}
				return retardo+this.dato;
				
			}

		}
	}
}
