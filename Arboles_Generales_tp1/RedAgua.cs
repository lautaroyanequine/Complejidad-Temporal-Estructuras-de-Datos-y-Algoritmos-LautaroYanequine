/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 8/4/2022
 * Hora: 15:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Arboles_Generales
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class RedAgua
	{
		ArbolGeneral<float> red;
		
		
		public RedAgua(ArbolGeneral<float> ar)
		{
			red=ar;
		}
		
			public float  minimoCaudal(float caudal){
			Cola<ArbolGeneral<float>> c = new Cola<ArbolGeneral<float>>();
			ArbolGeneral<float> arbolAux;
			float min = caudal ;
			
			red.setDatoRaiz(caudal);
			
			c.encolar(red);
			while(!c.esVacia()){
				arbolAux = c.desencolar();
				
				//Proceso el dato
				if(!arbolAux.esHoja())
				{
					float caudalHijos = arbolAux.getDatoRaiz() / arbolAux.getHijos().Count;
					
					if(caudalHijos < min)
						min=caudalHijos;
				
					foreach(var hijo in arbolAux.getHijos())
					{
						hijo.setDatoRaiz(caudalHijos);
						c.encolar(hijo);	
					}
				}
								
			}		
			
			return min;
		}		
		
	}
}
