using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class Punto
	{
		// Atributos de clase
		private int x, y;

		private static int contadorDeObjetos = 0;

		// Aunque es publica no se pude modificar fuera de la clase por una instancia
		// Solo se puede acceder por medio de la clase
		// Una constante se asume como static
		public const int Prueba = 10;

		// Constructor con parametros
		public Punto(int x, int y)
		{
			this.x = x;
			this.y = y;

			contadorDeObjetos++;

			Console.WriteLine($"Coorenanda x: {x}, Coordenada Y: {y}");
		}

		// Constructor sin parametros
		public Punto()
		{
			// Estado inicial de los atributos de clase
			this.x = 0;
			this.y = 0;

			contadorDeObjetos++;

			Console.WriteLine("Constructor sin parametros");
		}

		// Método para calcular la distancia del punto X y Y
		// int, double, String parametros de tipo primitivo
		public double distancia(Punto otroPunto) // parametro tipo objeto
		{
			int xDif = this.x - otroPunto.x;

			int yDif = this.y - otroPunto.y;

			// en googe: api .Net muestra todas las biblioteca de clases como Math
			double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
			
			return distanciaPuntos;
		}

		//public static int ContadorDeObjetos()
		//{
		//	return contadorDeObjetos;
		//}

		public static int ContadorDeObjetos() => contadorDeObjetos;

		
	}
}
