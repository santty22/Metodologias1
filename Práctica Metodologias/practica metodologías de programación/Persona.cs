/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 26/3/2025
 * Hora: 01:16
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica_metodologías_de_programación
{
	//Ejercicio 11
	public abstract class Persona : Comparable
	{
		string nombre;
		int dni;
		
		public Persona(string nombre, int dni)
		{
			this.nombre = nombre;
			this.dni = dni;
		}
		
		public string getNombre(){
			return this.nombre;
		}
		public int getDNI(){
			return this.dni;
		}
		
		//Implemento la Interface Comparable
		public bool sosIgual(Comparable c){
			return this.dni == ((Persona)c).dni;
		}
		public bool sosMenor(Comparable c){
			return this.dni < ((Persona)c).dni;
		}
		public bool sosMayor(Comparable c){
			return this.dni > ((Persona)c).dni;
		}
	}
}
