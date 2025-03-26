/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 26/3/2025
 * Hora: 01:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica_metodologías_de_programación
{
	//Ejercicio 12
	public class Alumno : Persona, Comparable
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
		public bool sosIgual(Comparable c){
			Console.Write("Presione 1 para comparar por legajo, 2 para comparar por promedio: ");
			int opcion = int.Parse(Console.ReadLine());
			if(opcion==1){
				return this.legajo == ((Alumno)c).legajo;
			}
			if(opcion==2){
				return this.promedio == ((Alumno)c).promedio;
			}
			else{
				throw new NotImplementedException("No eligió un número correcto para realizar la comparación.");
			}
		}
		public bool sosMenor(Comparable c){
			Console.Write("Presione 1 para comparar por legajo, 2 para comparar por promedio: ");
			int opcion = int.Parse(Console.ReadLine());
			if(opcion==1){
				return this.legajo < ((Alumno)c).legajo;
			}
			if(opcion==2){
				return this.promedio < ((Alumno)c).promedio;
			}
			else{
				throw new NotImplementedException("No eligió un número correcto para realizar la comparación.");
			}
		}
		public bool sosMayor(Comparable c){
			Console.Write("Presione 1 para comparar por legajo, 2 para comparar por promedio: ");
			int opcion = int.Parse(Console.ReadLine());
			if(opcion==1){
				return this.legajo > ((Alumno)c).legajo;
			}
			if(opcion==2){
				return this.promedio > ((Alumno)c).promedio;
			}
			else{
				throw new NotImplementedException("No eligió un número correcto para realizar la comparación.");
			}
		}
		
		//Solución a problema para mostrar en el ejecutable
		public override string ToString()
		{
			return string.Format("[Alumno Legajo={0}, Promedio={1}]", legajo, promedio);
		}
	}
}
