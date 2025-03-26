/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 24/3/2025
 * Hora: 20:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica_metodologías_de_programación
{
	//Ejercicio 2
	public class Numero : Comparable
	{
		private int valor;
		
		public Numero(int valor)
		{
			this.valor=valor;
		}
		public int getValor(){
			return this.valor;
		}
		
		//Implemento la Interface Comparable
		public bool sosIgual(Comparable c){
			return this.valor == ((Numero)c).valor;
		}
		public bool sosMenor(Comparable c){
			return this.valor < ((Numero)c).valor;
		}
		public bool sosMayor(Comparable c){
			return this.valor > ((Numero)c).valor;
		}
		
		//Solución a un problema para mostrar correctamente los números al ejecutar
		public override string ToString()
		{
			return valor.ToString();
		} 
	}
}
