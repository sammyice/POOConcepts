using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_5_Lista_Doblemente_Ligada;

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

    private int Compare(DoubleNode<T> a, DoubleNode<T> b)
    {
        if (a.Data == null && b.Data == null) return 0;
        if (a.Data == null) return -1;
        if (a.Data == null) return 1;

        return Comparer<T>.Default.Compare(a.Data, b.Data);
    }

    // Inserts a new node at the beginning of the list
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
            if (Compare(newNode, _head) == -1)
            {
                // Set the new node's next pointer to the current head
                newNode.Next = _head;
                // Set the current head's previous pointer to the new node
                _head.Prev = newNode;
                // Update head to the new node
                _head = newNode;
            }

          
        }
    }

    // Inserts a new node at the end of the list
    public void InsertAtEnd(T data)
    {
        var newNode = new DoubleNode<T>(data);
        if (_tail == null) // Empty list
        {
            // If the list is empty, both head and tail become the new node
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            // Link the current tail to the new node
            _tail.Next = newNode;
            // Set the new node's previous pointer to the current tail
            newNode.Prev = _tail;
            // Update tail to be the new node
            _tail = newNode;
        }
    }

    // Prints the list from head to tail
    public string GetForward()
    {
        var output = string.Empty;
        var current = _head;
        while (current != null)
        {
            // Output the current node's data followed by a bidirectional arrow
            output += $"{current.Data} <=>";
            current = current.Next;
        }
        return output.Substring(0, output.Length - 5);
    }

    // Prints the list from tail to head
    public string GetBackward()
    {
        var output = string.Empty;
        var current = _head;
        while (current != null)
        {
            // Output the current node's data followed by a bidirectional arrow
            output += $"{current.Data} <=>";
            current = current.Next;
        }
        return output.Substring(0, output.Length - 5);
    }

    // Removes the first node that contains the specified data
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

    
}
