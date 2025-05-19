using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DoubleListLinked.Logic;

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