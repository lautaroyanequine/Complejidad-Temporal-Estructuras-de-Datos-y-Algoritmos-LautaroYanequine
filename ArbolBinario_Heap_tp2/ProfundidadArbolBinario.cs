/*
 * Creado por SharpDevelop.
 * Usuario: USUARIO
 * Fecha: 16/09/2021
 * Hora: 02:37 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ArbolBinario_Heap
{
	/// <summary>
	/// Description of ProfundidadArbolBinario.
	/// </summary>
	public class ProfundidadArbolBinario
	{
		ArbolBinario<int> arbol;
		public ProfundidadArbolBinario(ArbolBinario<int> ar) 
		{
			arbol=ar;
		}
		
		public int SumaElementosProfundiad(int p)
		{
			
				Cola<ArbolBinario<int>> c = new Cola<ArbolBinario<int>>();
				ArbolBinario<int> arbolAux;
				int contador=0,nivel = 0;
				
				c.encolar(this.arbol); //encolamos arbol
				c.encolar(null); // encolamos separador			
			
				while(!c.esVacia())
				{
					arbolAux = c.desencolar();
					
					if(arbolAux == null)
					{
						if(!c.esVacia())
						{
							nivel++;
							if(nivel>p)
								break;
							else{
								c.encolar(null);
							}
						}						
					}
					else
					{
						if(nivel == p)
							contador=contador+arbolAux.getDatoRaiz();
						if(nivel>p)
							break;
					
						if(arbolAux.getHijoIzquierdo() != null)
							c.encolar(arbolAux.getHijoIzquierdo());
			
						if(arbolAux.getHijoDerecho() != null)
							c.encolar(arbolAux.getHijoDerecho());
					}
				}
				return contador;
			
		
		}
	}
}
