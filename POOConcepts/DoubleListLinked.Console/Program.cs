using DoubleListLinked.Logic;

var list = new DoublyLinkedList<string>();
var opc = "0";

do
{
    opc = Menu();
    switch (opc)
    {
        case "1":
            Console.Write("Ingrese un dato al principio de la lista: \n");
            var insertAtBeginningData = Console.ReadLine();
            if (insertAtBeginningData != null)
            {
                list.InsertAtBeginning(insertAtBeginningData);
            }
            break;
        case "2":
            Console.Write("Ingrese un dato al final de la lista: \n");
            var insertAtEndData = Console.ReadLine();
            if (insertAtEndData != null)
            {
                list.Insert(insertAtEndData);
            }
            break;
        case "3":
            Console.Write("Ingrese un dato a la lista: \n");
            var insertData = Console.ReadLine();
            if (insertData != null)
            {
                list.Insert(insertData);
            }
            break;

        case "4":
            Console.Write("Ver la lista de adelante hacia atrás head -> tail \n");
            Console.Write(list.GetForward() + "\n");
            break;

        case "5":
            Console.Write("Ver la lista de atrás hacia adelante tail -> head \n");
            Console.Write(list.GetBackward() + "\n");
            break;

        case "6":
            list.Sort();
            Console.Write("Lista ordenada descendentemente \n");
            list.Print();
            break;

        case "7":
            Console.Write("Mostrar la(s) moda(s) \n");
            list.ShowMode();
            break;

        case "8":
            Console.Write("Mostrar gráfico \n");
            list.ShowGraph();
            break;

        case "9":
            Console.Write("Ingrese el dato que desea verificar si existe: ");
            var existData = Console.ReadLine();
            if (list.Exists(existData))
            {
                Console.WriteLine("El elemento existe en la lista. ");
            }
            break;

        case "10":
            Console.Write("Entre el dato que desea eliminar: ");
            var remove = Console.ReadLine();
            if (remove != null)
            {
                list.Remove(remove);
                Console.WriteLine("El dato: " + remove + " fue eliminado.");
            }
            break;

        case "11":
            Console.Write("Entre el dato que desea eliminar con todas las concurrencias: ");
            var removeAll = Console.ReadLine();
            if (removeAll != null)
            {
                list.RemoveAll(removeAll);
                Console.WriteLine("El dato: " + removeAll + " fue eliminado y todas sus concurrencias.");
            }
            break;

        case "12":
            Console.Write("Lista de elementos");
            list.Print();
            break;
    }



}
while (opc != "0");

string Menu()
{
    Console.WriteLine("1. Adicionar al principio");
    Console.WriteLine("2. Adicionar al final");
    Console.WriteLine("3. Adicionar");
    Console.WriteLine("4. Mostrar hacia adelante");
    Console.WriteLine("5. Mostrar hacia atrás");
    Console.WriteLine("6. Ordenar descendentemente");
    Console.WriteLine("7. Mostrar la(s) moda(s)");
    Console.WriteLine("8. Mostrar gráfico");
    Console.WriteLine("9. Existe");
    Console.WriteLine("10. Eliminar una ocurrencia");
    Console.WriteLine("11. Eliminar todas las ocurrencias");
    Console.WriteLine("12. Imprimir");
    Console.WriteLine("Elige una opción: ");

    return Console.ReadLine() ?? "0";
}