
namespace stack
{
  class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
         this.data = data;
        }
    }
  class StackLinkedList
    {
       public Node top;

        public bool isEmpty()
        {
            if (top == null)
            {
                return true;
            }
            return false;
        }
        //there is  not isfull in linkedlist stack or array
        public void push(int x)
        {
            Node temp=new Node(x);
            temp.next = top;
            top = temp;
        }
        public int pop()
        {
            int x;
            if (isEmpty()) {
                Console.WriteLine("stack underflow");
                return int.MinValue;
            }
            x = top.data;
            top = top.next;
            return x;
        }
        public int peek()
        {
            if(isEmpty())
            {
                Console.WriteLine("stack under flow");
                return int.MinValue;    
            }
            return top.data;
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Node p = top;
            while (p != null)
            {
                Console.WriteLine(p.data);
                p = p.next;
            }
        }
   }
    class StackArray
    {
        int top;
        int[] data;
        public StackArray(int size)
        {
            data=new int[size];
        }
        public  bool isFull()
        {
            if (top == data.Length - 1)
            {
                return true;
            }
            return false;
        }
        public bool isEmpty() {

            if (top == -1)
            {
                return true;
            }
            return false;
        }
        public void push(int x)
        {
            if(isFull())
            {
                Console.WriteLine("stack overflow");
                return;
            }
            top++;
            data[top] = x;
        }
        public int pop() {
            int x;
            if (isEmpty())
            {
                Console.WriteLine("stack under flow");
                return int.MinValue;
            }
            x = data[top];
            top--;
            return x;

        }
        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack under flow");
                return int.MinValue;
            }
            return data[top];
        }
        public  void display()
        {
            // if is not empty
            for(int i=top;i<=0;i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
