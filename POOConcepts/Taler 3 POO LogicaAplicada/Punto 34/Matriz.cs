using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojdeArena
{
    class Matriz
    {
        private int[,] _matriz; //Almacenará la matriz
        private int _n;

        // Constructor por defecto, inicializa la matriz con un tamaño de 10
        public Matriz()
        {
            _n = 11;
            _matriz = new int[_n, _n];
        }

        public Matriz(int n)
        {
            _n = ValidateN(n); // Validamos el tamaño
            _matriz = new int[_n, _n]; // Creamos la matriz con el tamaño validado
        }

        public int N
        {
            get => _n;
            set => _n = ValidateN(value); // Validamos al establecer un nuevo tamaño
        }


        // Método para validar el tamaño de la matriz
        public int ValidateN(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("El número ingresado no es válido. Por favor, ingrese un número positivo.");
            }
            return n;
        }

        // Método para llenar la matriz con la fórmula
        public void LlenarMatriz()
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _matriz[i, j] = i + j; // Llenar cada celda con la fórmula
                }
            }
        }

        // Método para mostrar la matriz completa
        public void MostrarMatrizCompleta()
        {
            Console.WriteLine("\nMATRIZ COMPLETA:");
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    if (i == 0)
                    {
                        _matriz[i, j] = j; // Primera fila: 0, 1, 2, ..., 10
                    }
                    else
                    {
                        _matriz[i, j] = _matriz[i - 1, j] + 2; // Incremento de 2 en las demás filas
                    }
                    Console.Write($"{_matriz[i, j],4} "); // Mostramos cada valor con 4 espacios
                }
                Console.WriteLine(); // Nueva línea al final de cada fila
            }
        }

        // Método para mostrar el reloj de arena
        public void RelojdeArena()
        {
            Console.WriteLine("\nRELOJ DE ARENA:");
      
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // Condiciones para el patrón de reloj de arena
                    if (j >= i && j < N - i || j <= i && j >= N - i - 1)
                    {
                        Console.Write($"{_matriz[i, j],4} "); // Número dentro del reloj de arena
                    }
                    else
                    {
                        Console.Write("     "); // Espacio vacío para mantener la forma
                    }
                }
                Console.WriteLine();
            }
        }
    }
}