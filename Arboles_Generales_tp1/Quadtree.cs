/*
 * Creado por SharpDevelop.
 * Usuario: Lautaro
 * Fecha: 8/4/2022
 * Hora: 21:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Arboles_Generales
{
	/// <summary>
	/// Description of Quadtree.
	/// </summary>
		public class Quadtree
	{
		
		private string color;
		private List<Quadtree>hijos = new List<Quadtree>();

		public Quadtree(string dato) {
			if(esHoja())
			color = dato;
	
		}
	
		public string getDatoRaiz() {
			return color;
		}
		public void setDatoRaiz(string dat){
			color = dat;
		}
	
		public List<Quadtree> getHijos() {
			return hijos;
		}
	
		public void agregarHijo(Quadtree hijo) {
			this.getHijos().Add(hijo);
		}
	
		public void eliminarHijo(Quadtree hijo) {
			this.getHijos().Remove(hijo);
		}
	
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
		
	
		
		//RECORRIDOS    - kAlgoritmos que nos permiten visitar cada nodo una vez

	
		
		public double retornaNegro(){
			Cola<Quadtree> c = new Cola<Quadtree>();
			Quadtree quadtreeAux;
			
			int nivel = 0;
			int px=1024;
			double acumulador=0;
			
			c.encolar(this);
			c.encolar(null);
			
			
			while(!c.esVacia()){
				quadtreeAux = c.desencolar();
				
				if(quadtreeAux == null){
					if(!c.esVacia()){
						nivel++;
					
						c.encolar(null);
					}						
				}
				else{
					if(quadtreeAux.esHoja() && quadtreeAux.getDatoRaiz()=="negro")
					{
						acumulador= acumulador+(px / Math.Pow(4,nivel) );
					}
					
					foreach(var hijo in quadtreeAux.hijos)
						c.encolar(hijo);
				}
			}
			
			return acumulador;
		}		


		//Consideraciones punto 6
		//Nodo raiz toda la canti de px
		//stringq diga q color es
		//Si no es hoja va a estar subdividido si o si en 4
		//El nodo es blanco o negro si es hoja o un nodo con 4 hijos
		//Los nodos de cada nivel representan el total divididio 4 elevado al nivel
		//Recorrido por nivel con separacion
		//Ver video 
	}
}
