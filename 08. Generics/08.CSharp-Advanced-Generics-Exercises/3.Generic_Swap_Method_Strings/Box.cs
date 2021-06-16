﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Generic_Swap_Method_Strings
{
    public class Box<T>
    {
        public Box(T element)
        {
            Element = element;
        }

        public Box(List< T>elementsList)
        {
            Elements = elementsList;
        }

        public List< T> Elements { get; }

        public T Element { get; }

        public void Swap(List<T> elements, int indexOne, int indexTwo)
        {
            T firstEl = elements[indexOne];
            elements[indexOne] = elements[indexTwo];
            elements[indexTwo] = firstEl;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (T element in Elements)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }

            return sb.ToString().TrimEnd();
            // return $"{typeof(T)}: {Element}";
        }
    }
}
