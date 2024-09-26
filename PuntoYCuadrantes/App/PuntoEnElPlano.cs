using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PuntoYCuadrantes.App
{
    public class PuntoEnElPlano
    {
        // Variables privadas que almacenan las coordenadas X e Y del punto
        private double Puntox;
        private double Puntoy;

        // Método privado que solicita al usuario los puntos X e Y
        (double, double) ObtenerPuntos()
        {
            double puntx; // Variable temporal para almacenar la coordenada X
            double punty; // Variable temporal para almacenar la coordenada Y

            // Solicita al usuario que ingrese la coordenada X y valida la entrada
            Console.Write("Por favor digite el punto (X): ");
            while (true)
            {
                try
                {
                    puntx = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a un número
                    break; // Sale del ciclo si la entrada es válida
                }
                catch (Exception)
                {
                    Console.WriteLine("Entrada inválida. Por favor ingrese un número válido."); // Muestra mensaje de error
                }
            }

            // Línea en blanco para separar visualmente las entradas
            Console.Write("");

            // Solicita al usuario que ingrese la coordenada Y y valida la entrada
            Console.Write("Por favor digite el punto (Y): ");
            while (true)
            {
                try
                {
                    punty = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a un número
                    break; // Sale del ciclo si la entrada es válida
                }
                catch (Exception)
                {
                    Console.WriteLine("Entrada inválida. Por favor ingrese un número válido."); // Muestra mensaje de error
                }
            }

            // Pausa de 2 segundos para que el usuario pueda ver los datos antes de limpiar la consola
            Thread.Sleep(2000);
            Console.Clear(); // Limpia la consola para mejorar la presentación

            return (puntx, punty); // Devuelve las coordenadas X e Y como una tupla
        }

        // Método público que determina en qué cuadrante o eje se encuentra el punto
        public void Plano()
        {
            // Llama al método ObtenerPuntos() y asigna los valores retornados a las variables privadas Puntox y Puntoy
            (Puntox, Puntoy) = ObtenerPuntos();

            // Muestra las coordenadas ingresadas
            Console.WriteLine($"Punto A: ({Puntox},{Puntoy})");

            // Determina el cuadrante o eje basado en los valores de Puntox y Puntoy

            if (Puntox > 0 && Puntoy > 0)
            {
                // Primer cuadrante: ambos valores son positivos
                Console.WriteLine("El punto A se encuentra en el primer (I) cuadrante.");
            }

            if (Puntox < 0 && Puntoy > 0)
            {
                // Segundo cuadrante: X es negativo, Y es positivo
                Console.WriteLine("El punto A se encuentra en el segundo (II) cuadrante.");
            }

            if (Puntox < 0 && Puntoy < 0)
            {
                // Tercer cuadrante: ambos valores son negativos
                Console.WriteLine("El punto A se encuentra en el tercer (III) cuadrante.");
            }

            if (Puntox > 0 && Puntoy < 0)
            {
                // Cuarto cuadrante: X es positivo, Y es negativo
                Console.WriteLine("El punto A se encuentra en el cuarto (IV) cuadrante.");
            }

            if (Puntox == 0 && Puntoy != 0)
            {
                // Si X es 0 y Y no, el punto está en el eje Y
                Console.WriteLine("El punto A se encuentra en el eje Y.");
            }

            if (Puntoy == 0 && Puntox != 0)
            {
                // Si Y es 0 y X no, el punto está en el eje X
                Console.WriteLine("El punto A se encuentra en el eje X.");
            }

            if (Puntox == 0 && Puntoy == 0)
            {
                // Si ambos valores son 0, el punto está en el origen
                Console.WriteLine("El punto A se encuentra en el origen (0,0).");
            }
        }
    }
}
