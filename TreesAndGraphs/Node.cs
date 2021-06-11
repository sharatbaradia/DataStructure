﻿using System;
using System.Collections.Generic;

namespace DataStructure.TreesAndGraphs
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }
}
