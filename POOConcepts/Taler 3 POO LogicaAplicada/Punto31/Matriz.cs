using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangularInferiorMatriz
{
    class Matriz
    {

        private int[,] _matriz; //Almacenará la matriz
        private int _n;

        // Constructor por defecto, inicializa la matriz con un tamaño de 10
        public Matriz()
        {
            _n = 10;
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

        // Método para llenar la matriz con la fórmula: Celda[i][j] = i + j
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
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    Console.Write($"{_matriz[i, j],3} "); // Mostramos cada valor con 3 espacios
                }
                Console.WriteLine(); // Nueva línea al final de cada fila
            }
        }

        // Método para mostrar la triangular inferior de la matriz
        public void MostrarTriangularInferior()
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j <= i; j++) // Solo mostramos donde j <= i
                {
                    Console.Write($"{_matriz[i, j],3} "); // Mostramos cada valor con 3 espacios
                }
                Console.WriteLine(); // Nueva línea al final de cada fila
            }
        }
    }
}