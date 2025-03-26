/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 24/3/2025
 * Hora: 20:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica_metodologías_de_programación
{
	//Ejercicio 3
	public interface Coleccionable
	{
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable c);
		bool contiene(Comparable c);
	}
}
