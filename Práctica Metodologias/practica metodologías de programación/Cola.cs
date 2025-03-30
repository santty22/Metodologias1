/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 24/3/2025
 * Hora: 20:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase_1
{
	//Ejercicio 4 parte 2
	public class Cola : Coleccionable
	{
		List<Comparable> elementos;
		
		public Cola()
		{
			this.elementos = new List<Comparable>();
		}
		
		public void encolar(Comparable c){
			this.elementos.Add(c);
		}
		public Comparable desencolar(){
			Comparable aux = this.elementos[0];
			this.elementos.RemoveAt(0);
			return aux;
		}
		
		//Implemento la Interface Coleccionable
		public int cuantos(){
			return this.elementos.Count;
		}
		public Comparable minimo(){
			Comparable minimoActual = this.elementos[0];
			for(int i=1; i<cuantos(); i++){
				if(this.elementos[i].sosMenor(minimoActual)){
				   	minimoActual = this.elementos[i];
				   }
			}
			return minimoActual;
		}
		public Comparable maximo(){
			Comparable maximoActual = this.elementos[0];
			for(int i=1; i<cuantos(); i++){
				if(this.elementos[i].sosMayor(maximoActual)){
				   	maximoActual = this.elementos[i];
				   }
			}
			return maximoActual;
		}
		public void agregar(Comparable c){
			this.encolar(c);
		}
		public bool contiene(Comparable c){
			for(int i=1; i<cuantos(); i++){
				if(this.elementos[i].sosIgual(c)){
					return true;
				}
			}
			return false;
		}
	}
}
