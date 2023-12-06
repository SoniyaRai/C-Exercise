

namespace ApplicationDevelop_Assignment
{
    public class Stack<T>
    {
        List<T> stacklist = new List<T>();

        public void Push(T item)
        {

            Console.WriteLine("Push method that adds an item of type T to the top of the stack");

            stacklist.Add(item);

            Console.WriteLine("New Item has been added:" + item);
            DisplayStack();



        }

        public T Pop()
        {
            if (!stacklist.Any())
            {
                Console.WriteLine("Stack is empty");
            }

            Console.WriteLine("Pop method to remove top item of the stack");


            int lastIndex = stacklist.Count - 1;
            T poppedItem = stacklist[stacklist.Count - 1];
            stacklist.RemoveAt(lastIndex);
            Console.WriteLine("Last Item has been popped" + poppedItem);
            DisplayStack();
            return poppedItem;
        }

        public T Peek()
        {
            if (!stacklist.Any())
            {
                Console.WriteLine("Stack is empty");
            }

            Console.WriteLine("Peek method to show top item of the stack without removing");


            var peekedData = stacklist[stacklist.Count - 1];
            Console.WriteLine("The top item of the stack without removing: " + peekedData);

            Console.WriteLine("Displaying Stack List ");

            DisplayStack();
            return peekedData;
        }


        public void isEmpty()
        {

            if (!stacklist.Any())
            {
                Console.WriteLine("True Stack is empty");
            }
            else
            {
                Console.WriteLine("False Stack is not empty");
            }

            Console.WriteLine();
        }





        public void DisplayStack()
        {

            if (!stacklist.Any())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                foreach (var i in stacklist)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
        }
    }
}
