# PuntoEnElPlano--PrimerosPasos-

# Punto en el Plano Cartesiano

Este repositorio contiene una solución en C# para representar un punto en el plano cartesiano y determinar en qué cuadrante o eje se encuentra.

## Descripción del Problema

El problema consiste en desarrollar una clase que represente un punto en el plano cartesiano y que incluya las siguientes funcionalidades:
1. **Cargar los valores de las coordenadas** \(x\) y \(y\).
2. **Imprimir en qué cuadrante** se encuentra el punto en función de las coordenadas ingresadas:

### Reglas para determinar el cuadrante:
- **Primer cuadrante**: \(x > 0\) y \(y > 0\)
- **Segundo cuadrante**: \(x < 0\) y \(y > 0\)
- **Tercer cuadrante**: \(x < 0\) y \(y < 0\)
- **Cuarto cuadrante**: \(x > 0\) y \(y < 0\)
- **Eje X**: Si \(y = 0\), el punto está en el eje X.
- **Eje Y**: Si \(x = 0\), el punto está en el eje Y.
- **Origen**: Si \(x = 0\) y \(y = 0\), el punto está en el origen.

## Solución Implementada

Se abordó el problema mediante la creación de una clase llamada `PuntoEnElPlano` con las siguientes funcionalidades:

### Clase `PuntoEnElPlano`

#### Atributos
- `Puntox`: Variable que almacena la coordenada \(x\).
- `Puntoy`: Variable que almacena la coordenada \(y\).

#### Método `ObtenerPuntos`
Este método se encarga de:
- Solicitar al usuario que ingrese las coordenadas \(x\) y \(y\).
- Validar las entradas del usuario para asegurarse de que sean números válidos.
- Retornar las coordenadas ingresadas como una tupla.

#### Método `Plano`
Este método:
- Llama al método `ObtenerPuntos` para capturar las coordenadas.
- Imprime las coordenadas ingresadas.
- Determina en qué cuadrante o eje se encuentra el punto usando condicionales (`if`):
  - **Cuadrantes**: Evalúa si \(x\) y \(y\) son positivas o negativas para identificar el cuadrante.
  - **Ejes**: Si alguna de las coordenadas es 0, se determina si el punto está en el eje X o Y.
  - **Origen**: Si ambas coordenadas son 0, se identifica el origen.

### Clase `Program`

El `Main` de la aplicación se encuentra en la clase `Program`, que ejecuta el programa principal:
- Se crea una instancia de la clase `PuntoEnElPlano`.
- Se llama al método `Plano`, el cual obtiene las coordenadas y determina su ubicación en el plano.

## Ejemplo de Uso

```bash
$ dotnet run
Por favor digite el punto (X): 5
Por favor digite el punto (Y): -3
Punto A: (5,-3)
El punto A se encuentra en el cuarto (IV) cuadrante.
