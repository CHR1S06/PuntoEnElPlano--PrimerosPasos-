using PuntoYCuadrantes.App; // Importa el espacio de nombres donde está definida la clase PuntoEnElPlano
using System;

namespace PuntoYCuadrantes
{
    internal class Program
    {
        // Método principal que ejecuta la aplicación
        static void Main(string[] args)
        {
            // Creación de una instancia (objeto) de la clase PuntoEnElPlano
            PuntoEnElPlano punto = new PuntoEnElPlano();

            // Llamada al método Plano() del objeto punto para determinar el cuadrante o eje donde se encuentra el punto
            punto.Plano();
        }
    }
}
