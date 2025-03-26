/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 23/3/2025
 * Hora: 20:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace practica_metodologías_de_programación
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Ejercicio 7
			/*
			Pila NuevaPila = new Pila();
			llenar(NuevaPila);
			informar(NuevaPila);
			Cola NuevaCola = new Cola();
			llenar(NuevaCola);
			informar(NuevaCola);
			//Ejercicio 9
			ColeccionMultiple NuevaMultiple = new ColeccionMultiple(NuevaPila,NuevaCola);
			informar(NuevaMultiple);
			*/
			//Ejercicio 10: qué modifiqué en el resto del código tras la creación de ColeccionMultiple?
			//Realmente nada, pero podría haber modificado la variable cuantos() de Coleccionable para que me pueda dar int[] y no solo int
			
			//Ejercicio 14: En principio no funcionó, después de modificar algunas partes funcionó.
			//Si, fue necesario implementar la interface Comparable para Alumno de forma explícita ya que antes comparaba DNI, y en realidad debe comparar promedios
			Pila PilaAlumnos = new Pila();
			Cola ColaAlumnos = new Cola();
			ColeccionMultiple MultipleAlumnos = new ColeccionMultiple(PilaAlumnos,ColaAlumnos);
			llenarAlumnos(PilaAlumnos);
			llenarAlumnos(ColaAlumnos);
			informar(MultipleAlumnos);
			
			Console.ReadKey(true);
		}
		
		//Ejercicio 5
		public static void llenar(Coleccionable col){
			Random rnd = new Random();
			for (int i=0; i<20; i++){
				Comparable aux = new Numero(rnd.Next(1, 101));
				col.agregar(aux);
			}
		}
		//Ejercicio 6
		public static void informar(Coleccionable col){
			Console.WriteLine(col.cuantos());
			Console.WriteLine(col.minimo());
			Console.WriteLine(col.maximo());
			Console.WriteLine("Desea chequear si algún número se encuentra en la colección? Ingrese 'SI'");
			string check = Console.ReadLine();
			if(check=="SI"){
				Console.Write("Ingrese el número a buscar: ");
				Comparable aux = new Numero(int.Parse(Console.ReadLine()));
				if(col.contiene(aux)){
					Console.WriteLine("El número está en la colección");
				}
				else{
					Console.WriteLine("El número no está en la colección");
				}
			}
			//La opción ternaria sería:
			//Console.WriteLine(col.contiene(aux)? "El número está en la colección" : "El número no está en la colección");
		}
		//Ejercicio 13
		public static void llenarAlumnos(Coleccionable col){
			for(int i=0; i<2; i++){
				Console.Write("Nombre del alumno: ");
				string n = Console.ReadLine();
				Console.Write("DNI del alumno: ");
				int d = int.Parse(Console.ReadLine());
				Console.Write("Legajo del alumno: ");
				int l = int.Parse(Console.ReadLine());
				Console.Write("Promedio del alumno: ");
				double p = double.Parse(Console.ReadLine());
				Comparable aux = new Alumno(n,d,l,p);
				col.agregar(aux);
			}
		}
	}
}