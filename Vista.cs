using System;
using Controlador;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
			procesocontrolador controlador = new procesocontrolador();
            do { 
           
				Console.WriteLine("Calculo de monedas, escoja las opciones 1,2,3,4 o X para salir");
				Console.WriteLine("1) Calcular de bolivar a Dolar"); // Calcular de bolivar a Dolar
				Console.WriteLine("2) Calcular de Dolar a bolivar"); // Calcular de Dolar a bolivar
				Console.WriteLine("3) Calcular de bolivar a Peso Colombiano"); // Calcular de bolivar a Peso Colombiano
			    Console.WriteLine("4) Calcular de Peso Colombiano a bolivar"); //  Calcular de Peso Colombiano a bolivar
				Console.WriteLine("5) Calcular de bolivar a sol peruano"); // calcular de bolivar a sol peruano
				Console.WriteLine("6) Calcular de Sol peruano a bolivar"); // Calcular de Sol peruano a bolivar

				Console.WriteLine("Presione X para Salir");
				respuesta = Console.ReadLine();
				
				if (respuesta=="1") {
					Console.WriteLine("Ingrese cantidad de bolivar: ");
					double bolivar = int.Parse(Console.ReadLine());
					double dolar = controlador.traer_de_bolivar_a_dolar(bolivar);
					Console.WriteLine("En dolar: " + dolar + ", ahora, desea continuar?: X para si");
					respuesta = Console.ReadLine();
				} else if (respuesta =="2"){
					Console.WriteLine("Ingrese cantidad de dolares: ");
					double bolivar =int.Parse(Console.ReadLine());
					double dolar = controlador.traer_de_dolar_a_bolivar(bolivar);
					Console.WriteLine("En bolivar: " + dolar + ", ahora, desea cointunar?: X para si");
					respuesta = Console.ReadLine();
				} else if (respuesta =="3"){
					Console.WriteLine("Ingrese cantidad de bolivar: ");
					double bolivar = int.Parse(Console.ReadLine());
					double peso = controlador.traer_de_bolivar_a_peso(bolivar);
					Console.WriteLine("En Peso: " + peso + ", ahora, desea continuar?: X para si");
					respuesta = Console.ReadLine();
				} else if (respuesta =="4"){
					Console.WriteLine("Ingrese cantidad de pesos: ");
					double bolivar = int.Parse(Console.ReadLine());
					double peso = controlador.traer_de_peso_a_bolivar(bolivar);
					Console.WriteLine("En bolivares: " + peso + ", ahora, desea continuar?: X para si");
					respuesta = Console.ReadLine();
				} else if (respuesta =="5"){
					Console.WriteLine("Ingrese cantidad de bolivar: ");
					double bolivar = int.Parse(Console.ReadLine());
					double sol = controlador.traer_de_bolivar_a_sol(bolivar);
					Console.WriteLine("En Soles: " + sol + ", ahora, desea continuar?: X para si");
					respuesta = Console.ReadLine();
				}
				else if (respuesta =="6"){
					Console.WriteLine("Ingrese cantidad de soles: ");
					double bolivar = int.Parse(Console.ReadLine());
					double sol = controlador.traer_de_sol_a_bolivar(bolivar);
					Console.WriteLine("En bolivares: " + sol + ", ahora, desea continuar?: X para si");
					respuesta = Console.ReadLine();
				}
				else {
					 Console.WriteLine("Debe poner una opcion válida, presione x para repetir");
				     respuesta = Console.ReadLine();
				     }
				     
               } while (respuesta == "x"  || respuesta == "X");
        }        
    }
        
}
