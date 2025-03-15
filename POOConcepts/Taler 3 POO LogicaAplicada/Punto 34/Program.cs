using RelojdeArena;

try
{
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.Clear();
    Console.WriteLine("**** RELOJ DE ARENA ****");
    Console.Write("Ingrese orden de la matriz: ");

    int n = int.Parse(Console.ReadLine());

    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.BackgroundColor = ConsoleColor.DarkGray;

    // Crear instancia de la clase MatrizCuadrada
    Matriz matriz = new Matriz(n);

    // Llenar y mostrar la matriz
    matriz.LlenarMatriz();
    matriz.MostrarMatrizCompleta();
    matriz.RelojdeArena();
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}