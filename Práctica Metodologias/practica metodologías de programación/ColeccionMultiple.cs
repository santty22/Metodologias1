/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 25/3/2025
 * Hora: 16:05
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica_metodologías_de_programación
{
	//Ejercicio 8
	public class ColeccionMultiple : Coleccionable
	{
		private Pila pila;
		private Cola cola;
		
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pila = p;
			this.cola = c;
		}
		
		//Implemento la Interface Coleccionable
		public int cuantos(){
			return pila.cuantos() + cola.cuantos();
		}
		public Comparable minimo(){
			if (pila.cuantos()==0){
				return cola.minimo();
			}
			if (cola.cuantos()==0){
				return pila.minimo();
			}
			Comparable minPila = pila.minimo();
			Comparable minCola = cola.minimo();
			
			return minPila.sosMenor(minCola) ? minPila : minCola;
		}
		public Comparable maximo(){
			if (pila.cuantos()==0){
				return cola.maximo();
			}
			if (cola.cuantos()==0){
				return pila.maximo();
			}
			Comparable maxPila = pila.maximo();
			Comparable maxCola = cola.maximo();
			
			return maxPila.sosMayor(maxCola) ? maxPila : maxCola;
		}
		public void agregar(Comparable c){
			throw new Exception("No se pueden agregar elementos directamente a una colección multiple.");
		}
		public bool contiene(Comparable c){
			if(pila.contiene(c)){
				return true;
			}
			return cola.contiene(c);
		}
	}
}
