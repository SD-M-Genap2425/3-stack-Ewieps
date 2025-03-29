using System;

    namespace Solution.BracketValidation;

        public class Node
        {
            public char Data {get; set;}
            public Node Next {get; set;}
            public Node(char data)
            {
                Data = data; 
                Next = null;
            }
        }

        public class BracketValidator
        {
            private Node top;

            public BracketValidator()
            {
                this.top = null;
            }

            public void Push(char item)
            {
                Node newNode = new Node(item);
                newNode.Next = top;
                top = newNode;
            }

            public char Pop()
            {
                if (top == null)
                {
                    Console.WriteLine("Kosong");
                    return '\0';
                }
                else
                {
                    char item = top.Data;
                    top = top.Next;
                    return item;
                }
            }

            private bool BracketMatch(char left, char right)
            {
                return  (left == '(' && right == ')')
                ||      (left == '{' && right == '}')
                ||      (left == '[' && right == ']');
            }

            public bool ValidasiEkspresi(string ekspresi)
            {
                foreach (char i in ekspresi)
                {
                    if (i == '(' || i == '{' || i == '[') Push(i);
                    
                    else if (i == ')' || i == '}' || i == ']')
                    {
                        char isPop = Pop();
                        if (isPop == '\0' || !BracketMatch(isPop, i)) return false;
                    }
                }
            return top == null;
            }
        }