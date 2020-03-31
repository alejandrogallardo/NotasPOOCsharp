using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			// ============================================ 
			// Clase TipoCambio
			// ============================================
			
			// obj es una instancia de la clase TipoCambio | new TipoCambio() llama al constructor vacio de la clase
			TipoCambio obj = new TipoCambio();

			// no se le puede asignar un numero negativo porque esta condicionado el
			// obj.tipoCambio(-1); 
			Console.WriteLine("La cantidad es: " + obj.convierte(15.2));
			
			Console.WriteLine("");

			// ============================================ 
			// Clase Circulo
			// ============================================
			Circulo rueda = new Circulo();
			// rueda.pi = 4; // si este valor fuera publico
			Console.WriteLine("El Area del circulo es: " + rueda.calculoArea(15));

			Console.WriteLine("");
			// ============================================ 
			// Clase Carro
			// ============================================
			Carro cUno = new Carro();

			Console.WriteLine("Primer constructro: " + cUno.getInfoCarro());

			Carro cDos = new Carro(4, 5, "Azul", 5.6); // Se le agregaron argumentos
			Console.WriteLine("Constructro con argumentos: " + cDos.getInfoCarro());

			Carro cTres = new Carro();
			cTres.setExtras(true, "Cuero");
			Console.WriteLine("Carro 3 con extras: " + cTres.getExtras());

			Console.WriteLine("");
			// ============================================ 
			// Clase Punto
			// ============================================
			realizarTarea();
			Console.WriteLine("");

			// Se manda a llamar al metodo ContadorDeObjetos por medio de la clase Punto
			Console.WriteLine($"Cantidad de objetos Punto: {Punto.ContadorDeObjetos()}");

			Console.WriteLine("");

			// ============================================ 
			// Clase Anonima
			// ============================================
			var miVariable = new { Nombre = "Juan", Edad = 19 };

			Console.WriteLine($"Clase estatica -- Nombre: {miVariable.Nombre} Edad: {miVariable.Edad}");

			// Al tener el mismo orden, tipo y cantidad de campos se determina que son de la misma clase
			var miOtraVariable = new { Nombre = "Pedro", Edad = 25 };

			miVariable = miOtraVariable;
		}

		static void realizarTarea()
		{
			// TODO:
			// Ver > Lista de tareas | para ver los comentarios de tipo TODO

			Punto origen = new Punto();

			Punto destino = new Punto(128, 8);
			

			double distancia = origen.distancia(destino);

			Console.WriteLine($"La distancia entre X y Y es: {distancia}");
			
		}
	}

	// ============================================ 
	// Clase TipoCambio
	// ============================================
	class TipoCambio
	{
		private double dolar = 7.90;

		// No importa si no esta declarado un constructor 
		// automaticamente se llama al constructor vacio
		public TipoCambio() { }

		public double convierte(double cantidad) 
		{
			return cantidad * dolar;
		}

		public void tipoCambio(double nuevoValor)
		{
			if (nuevoValor < 0)
			{
				Console.WriteLine("No es posible asignar ese valor");
			}
			else
			{
				dolar = nuevoValor;
			}

			// Otra forma de poner el if
			//if (nuevoValor < 0) dolar = 7.69;
			//else dolar = nuevoValor;
		}
	}

	// ============================================ 
	// Clase Carro | Parcial con los constructores
	// ============================================
	partial class Carro // en C# una clase se puede dividir en archivos parciales
	{

		// Atributos de la clase Carro
		private int ruedas;
		private int puertas;
		private string color;
		private double motor;
		private double largo;
		private bool climatizador;
		private double ancho;
		private string tapiceria;

		public Carro() // Constructor, estado inicial de nuestos objetos
		{
			this.ruedas = 4;
			this.motor = 5.5;
			this.puertas = 4;
			this.color = "blaco";
			this.tapiceria = "Tela";
		}

		public Carro(int ruedas, int puertas, string color, double motor) // Constructor con Parametros
		{
			// Aqui se utiliza this porque los parametros
			// tienen el mismo nombre que los atributos de la clase
			this.ruedas = ruedas;
			this.motor = motor;
			this.puertas = puertas;
			this.color = "blaco";
			this.tapiceria = "Tela";
		}

	}

	// ============================================ 
	// Clase Carro | Parcial con métodos get y set
	// ============================================
	partial class Carro
	{
		// Método void no de retorna nada ya que se usa para asignar valores
		public void setExtras(bool pClimatizador, String pTapiceria)
		{
			// Aqui no uso this porque los parametros tienen nombre diferente 
			// a los atributos de clase, aunque por lo general se suelen llamar 
			// igual y utilizar this
			climatizador = pClimatizador;
			tapiceria = pTapiceria;
		}

		// Este tipo de método retorna un string
		public String getInfoCarro()
		{
			return "Informacion del vehiculo: " + "LLantas: " + ruedas + " Motor: " + motor + " Puertas: " + puertas + " Color: " + color + " Tapiceria: " + tapiceria + " Climatizador: " + climatizador;
		}

		public String getExtras() 
		{
			return "Extras del carro: " + " Tapiceria: " + tapiceria + " Climatizador: " + climatizador;
		}
	}

	// ============================================ 
	// Clase Circulo
	// ============================================
	class Circulo
	{
		double pi = 3.14159;

		public double calculoArea(int radio)
		{
			//return pi * radio * radio;
			// Pow eleva a una potencia
			// Sqrt obtiene la raíz cuadrada
			return pi * Math.Pow(radio, 2); 
		}
	}
}
