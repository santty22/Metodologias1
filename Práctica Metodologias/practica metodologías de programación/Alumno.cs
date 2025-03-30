/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 26/3/2025
 * Hora: 01:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase_1
{
	//Ejercicio 12
	public class Alumno : Persona
	{
		private int legajo;
		private double promedio;
		
		public Alumno(string nombre, int dni, int legajo, double promedio) : base(nombre, dni)
		{
			this.legajo=legajo;
			this.promedio=promedio;
		}
		
		public int getLegajo(){
			return legajo;
		}
		public double getPromedio(){
			return promedio;
		}
		
		//Implemento la Interface Comparable
		public override bool sosIgual(Comparable c){
			return this.promedio == ((Alumno)c).promedio;
		}
		public override bool sosMenor(Comparable c){
			return this.promedio < ((Alumno)c).promedio;
		}
		public override bool sosMayor(Comparable c){
			return this.promedio > ((Alumno)c).promedio;
		}
		
		//Solución a problema para mostrar en el ejecutable
		public override string ToString()
		{
			return string.Format("[Nombre= {0}, DNI= {1} Legajo= {2}, Promedio= {3}]", getNombre(), getDNI(), legajo, promedio);
		}
	}
}
