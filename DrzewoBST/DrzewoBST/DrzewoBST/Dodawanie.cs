using System;
using System.Collections.Generic;

namespace DrzewoBTS
{
    // Klasa reprezentująca węzeł drzewa
    internal class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    // Klasa do zarządzania drzewem
    internal class Dodawanie
    {
        private Node root;
        private Usun usun;

        public Dodawanie()
        {
            root = null;
            usun = new Usun();
        }

        // Dodawanie liczby do drzewa
        public void Add(int value)
        {
            root = AddRecursive(root, value);
        }

        private Node AddRecursive(Node node, int value)
        {
            if (node == null)
            {
                return new Node(value);
            }

            if (value < node.Value)
            {
                node.Left = AddRecursive(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = AddRecursive(node.Right, value);
            }

            return node;
        }

        // Usuwanie elementu z drzewa
        public void Remove(int value)
        {
            root = usun.Remove(root, value);
        }

        // Zbieranie wszystkich wartości z drzewa
        public List<int> GetNumbers()
        {
            List<int> values = new List<int>();
            GetNumbersRecursive(root, values);
            return values;
        }

        private void GetNumbersRecursive(Node node, List<int> values)
        {
            if (node != null)
            {
                GetNumbersRecursive(node.Left, values);
                values.Add(node.Value);
                GetNumbersRecursive(node.Right, values);
            }
        }
    }
}
