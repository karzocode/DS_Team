using System;
using System.Collections.Generic;

namespace DSA_Project
{
    public class MovieBST
    {
        private class Node
        {
            public Movie Value;
            public Node Left;
            public Node Right;

            public Node(Movie value)
            {
                Value = value;
            }
        }

        private Node root;

        private static int Compare(string a, string b)
        {
            return String.Compare(a, b, StringComparison.OrdinalIgnoreCase);
        }

        public bool Insert(Movie movie)
        {
            if (Search(movie.Title) != null)
                return false;

            root = Insert(root, movie);
            return true;
        }

        private Node Insert(Node node, Movie movie)
        {
            if (node == null)
                return new Node(movie);

            if (Compare(movie.Title, node.Value.Title) < 0)
                node.Left = Insert(node.Left, movie);
            else
                node.Right = Insert(node.Right, movie);

            return node;
        }

        public Movie Search(string title)
        {
            Node current = root;
            while (current != null)
            {
                int result = Compare(title, current.Value.Title);
                if (result == 0)
                    return current.Value;
                current = result < 0 ? current.Left : current.Right;
            }
            return null;
        }

        public bool Delete(string title)
        {
            if (Search(title) == null)
                return false;

            root = Delete(root, title);
            return true;
        }

        private Node Delete(Node node, string title)
        {
            if (node == null)
                return null;

            int result = Compare(title, node.Value.Title);
            if (result < 0)
            {
                node.Left = Delete(node.Left, title);
            }
            else if (result > 0)
            {
                node.Right = Delete(node.Right, title);
            }
            else
            {
                if (node.Left == null)
                    return node.Right;
                if (node.Right == null)
                    return node.Left;


                Node successor = node.Right;
                while (successor.Left != null)
                    successor = successor.Left;

                node.Value = successor.Value;
                node.Right = Delete(node.Right, successor.Value.Title);
            }
            return node;
        }

        public List<Movie> GetInOrder()
        {
            List<Movie> list = new List<Movie>();
            InOrder(root, list);
            return list;
        }

        private void InOrder(Node node, List<Movie> list)
        {
            if (node == null)
                return;

            InOrder(node.Left, list);
            list.Add(node.Value);
            InOrder(node.Right, list);
        }
    }
}
