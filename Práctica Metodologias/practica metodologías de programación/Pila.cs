/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 24/3/2025
 * Hora: 20:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase_1
{
	//Ejercicio 4 parte 1
	public class Pila : Coleccionable
	{
		List<Comparable> elementos;
		
		public Pila()
		{
			this.elementos = new List<Comparable>();
		}
		
		public void apilar(Comparable c){
			this.elementos.Add(c);
		}
		public Comparable desapilar(){
			Comparable aux = this.elementos[elementos.Count -1];
			this.elementos.RemoveAt(this.elementos.Count -1);
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
			this.apilar(c);
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
