/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 25/3/2025
 * Hora: 16:05
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase_1
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
			return pila.minimo().sosMenor(cola.minimo()) ? pila.minimo() : cola.minimo();
		}
		public Comparable maximo(){
			return pila.maximo().sosMayor(cola.maximo()) ? pila.maximo() : cola.maximo();
		}
		public void agregar(Comparable c){
		}
		public bool contiene(Comparable c){
			return pila.contiene(c) || cola.contiene(c);
		}
	}
}
