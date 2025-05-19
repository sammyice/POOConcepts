using System;
using System.Xml.Linq;
using System.Collections.Generic;

namespace DoubleListLinked.Logic;

public class DoublyLinkedList<T>
{
    // References to the head (first node) and tail (last node) of the list
    private DoubleNode<T> _head;
    private DoubleNode<T> _tail;

    // Constructor initializes an empty doubly linked list
    public DoublyLinkedList()
    {
        _head = null;
        _tail = null;
    }

    private int CompareTo(T a, T b)
    {
        if (a == null && b == null) return 0;
        if (a == null) return -1;
        if (b == null) return 1;

        // Verificamos si el tipo de dato es String, para hacer la comparacion
        // Y evitar las diferencias entre mayusculas y minusculas de un string
        if (typeof(T) == typeof(string))
        {
            int result = StringComparer.OrdinalIgnoreCase.Compare(a as string, b as string);
            // Convertimos los resultados en 1(ascendente) -1(descendente) 0(iguales)
            if (result > 0) return 1;
            if (result < 0) return -1;

            return 0;
        }
        // Comparamos los otros tipos de datos que podrias llegar
        return Comparer<T>.Default.Compare(a, b);
    }

    public void Sort()
    {
        if (_head == null && _head.Next == null) return;

        List<T> temporalList = new List<T>();
        DoubleNode<T> current = _head;

        // Agrego cada nodo a la lista
        while (current != null)
        {
            temporalList.Add(current.Data);
            current = current.Next;
        }

        // Ordenamos la lista
        temporalList.Sort((x, y) => CompareTo(x, y));

        // Reiniciamos el current para empezar desde el head
        current = _head;
        int index = 0; // El indice que permite acceder a la lista ordenada

        while (current != null)
        {
            current.Data = temporalList[index];
            current = current.Next;
            index++;
        }
    }

    // Agregar un nuevo nodo al final de la lista
    public void Insert(T data)
    {
        var node = new DoubleNode<T>(data);
        if (_tail == null)
        {
            _head = node;
            _tail = node;
        }
        else
        {

            _tail.Next = node;
            node.Prev = _tail;
            _tail = node;
            Sort();

        }
    }

    public bool Exists(T? data)
    {
        var current = _head;
        if (current == null) return false;

        while (current != null)
        {
            if (current.Data != null && current.Data.Equals(data)) return true;

            current = current.Next;
        }
        return false;
    }

    // Agregar un nuevo nodo al principio de la lista
    public void InsertAtBeginning(T data)
    {
        var newNode = new DoubleNode<T>(data);
        if (_head == null) // Empty list
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            // Set the new node's next pointer to the current head
            newNode.Next = _head;
            // Set the current head's previous pointer to the new node
            _head.Prev = newNode;
            // Update head to the new node
            _head = newNode;
        }
    }

    // Imprime la lista de head -> tail
    public string GetForward()
    {
        var output = string.Empty;
        var current = _head;
        while (current != null)
        {
            // Output the current node's data followed by a bidirectional arrow
            output += $"{current.Data} <-> ";
            current = current.Next;
        }
        return output.Substring(0, output.Length - 4);
    }

    // Imprime la lista de tail -> head
    public string GetBackward()
    {
        var output = string.Empty;
        var current = _tail;
        while (current != null)
        {
            // Output the current node's data followed by a bidirectional arrow
            output += $"{current.Data} <-> ";
            current = current.Prev;
        }
        return output.Substring(0, output.Length - 4);
    }

    // Elimina el primer nodo que coincida con el dato
    public void Remove(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                if (current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                else
                {
                    _head = current.Next; // Remove head
                }

                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else
                {
                    _tail = current.Prev; // Remove tail
                }

                break;
            }
            current = current.Next;
        }
    }

    public void RemoveAll(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                if (current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                else
                {
                    _head = current.Next; // Remove head
                }

                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else
                {
                    _tail = current.Prev; // Remove tail
                }
            }
            current = current.Next;
        }
    }


    public void ShowMode()
    {
        Dictionary<T, int> concurrences = new Dictionary<T, int>();
        // Recorro la lista y en guardo las concurrencias es un hash
        var current = _head;
        while (current != null)
        {
            if (concurrences.ContainsKey(current.Data))
            {
                concurrences.TryGetValue(current.Data, out int value);
                concurrences[current.Data] = value + 1;
            }
            else
            {
                concurrences.Add(current.Data, 1);
            }
            current = current.Next;
        }


        // Si no hay ningun elemento no hago nada.
        if (concurrences.Any())
        {
            // Obtengo cual es la cantidad maxima
            int maxCount = concurrences.Values.Max();
            // Busco cuales son los valores que mas se repiten
            var numbersWithMaxCount = concurrences.Where(pair => pair.Value == maxCount).Select(pair => pair.Key);
            Console.WriteLine($"{string.Join(", ", numbersWithMaxCount)}");
        }

    }

    public void ShowGraph()
    {
        Dictionary<T, int> concurrences = new Dictionary<T, int>();
        // Recorro la lista y en guardo las concurrencias es un hash
        var current = _head;
        while (current != null)
        {
            if (concurrences.ContainsKey(current.Data))
            {
                concurrences.TryGetValue(current.Data, out int value);
                concurrences[current.Data] = value + 1;
            }
            else
            {
                concurrences.Add(current.Data, 1);
            }
            current = current.Next;
        }

        // Recorro las concurrencias
        for (int index = 0; index < concurrences.Count; index++)
        {
            KeyValuePair<T, int> entry = concurrences.ElementAt(index);
            string countStars = "".PadRight(entry.Value, '*');
            Console.WriteLine(entry.Key + " " + countStars);
        }
    }
    // Imprime la lista
    public void Print()
    {
        DoubleNode<T> current = _head;
        while (current != null)
        {
            Console.Write(current.Data + " <-> ");
            current = current.Next;
        }
        Console.WriteLine("NULL \n");
    }
}