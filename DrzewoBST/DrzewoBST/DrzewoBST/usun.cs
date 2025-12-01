using System;

namespace DrzewoBTS
{
    internal class Usun
    {
        // Usuwanie węzła z drzewa BST
        public Node Remove(Node root, int value)
        {
            if (root == null) return root;

            // Przechodzimy do odpowiedniej gałęzi
            if (value < root.Value)
            {
                root.Left = Remove(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = Remove(root.Right, value);
            }
            else
            {
                // Węzeł do usunięcia znaleziony

                // Przypadek 1: Brak dzieci (liść)
                if (root.Left == null && root.Right == null)
                {
                    return null;
                }
                // Przypadek 2: Jeden potomek
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                // Przypadek 3: Dwa dzieci
                Node successor = GetSuccessor(root.Right); // Następca
                root.Value = successor.Value;  // Zamiana wartości z następcą
                root.Right = Remove(root.Right, successor.Value);  // Usuwamy następcę
            }

            return root;
        }

        // Znajdowanie najmniejszego elementu w prawym poddrzewie (następca)
        private Node GetSuccessor(Node node)
        {
            Node current = node;

            while (current.Left != null)
            {
                current = current.Left;
            }

            return current;
        }
    }
}
