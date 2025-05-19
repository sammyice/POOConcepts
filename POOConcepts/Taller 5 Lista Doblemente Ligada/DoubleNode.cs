using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Taller_5_Lista_Doblemente_Ligada;
    public class DoubleNode<T>
{
    public DoubleNode(T data)
    {
        Data = data;
        Next = null;
        Prev = null;
    }
   
    public T Data { get; set; }
    public DoubleNode<T> Next { get; set; }
    public DoubleNode<T> Prev { get; set; }
}