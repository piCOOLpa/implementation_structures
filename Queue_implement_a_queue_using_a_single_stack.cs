using System;
using System.Collections.Generic;
/*
Enqueue
Dequeue
print_elements

 */


namespace stack
{
	// C# program to implement basic stack 
	// operations 
	using System;
    using System.Linq;

    namespace ImplementStack
	{
		class Queue
		{
			private  Stack<int> recursive_queue = new Stack<int>();
			//   stack to implement the queue operation.
		
			public void Enqueue(int item)
			{
				// add an element at the end of the queue.
				recursive_queue.Push(item);
			}

			private int pop_recursive()
            {
				int first_element_inStack;
				if (recursive_queue.Count == 1)
                {
					// single element left in the stack.
					// first element inserted in order.
					first_element_inStack = recursive_queue.Pop();
					return first_element_inStack;
				}

				// traverse down the stack to get the first inserted element.

				int current_lastelement = recursive_queue.Pop();
				first_element_inStack = pop_recursive();
				recursive_queue.Push(current_lastelement);
				return first_element_inStack;
			}
			public int dequeue()
			{
				// remove the element from the Q in FIFO order .

				int element_popped = -1;

				if (recursive_queue.Count == 0)
				{
					Console.WriteLine("Stack is Empty");
					return element_popped;
				}
				else
				{
					element_popped = pop_recursive();
					Console.WriteLine("popped from stack : " +element_popped);
					return element_popped;
				}	
			}

		private void print_queue_elements_recursive()
            {
				// print the elements present in the queue in order of insertion.
				int current_lastelement;
				if (recursive_queue.Count == 1)
				{
					current_lastelement = recursive_queue.Pop();
					Console.Write(current_lastelement + ",");
					recursive_queue.Push(current_lastelement);
				}
				else
				{
					 current_lastelement = recursive_queue.Pop();
					print_queue_elements_recursive();
					Console.Write(current_lastelement + ",");
					recursive_queue.Push(current_lastelement);		
				}

			}
			public void print_queue_elements()
			{
				// print the elements present in the queue in order of insertion .
				if (recursive_queue.Count == 0)
				{
					Console.WriteLine("Stack is Empty");
					Console.WriteLine();
				}
				else
				{
					Console.Write("elements present in the Queue in the order of insertion : ");
					print_queue_elements_recursive();
					Console.WriteLine();
				}

			}
		}

		// Driver program to test above functions 
		class Program
		{
			static void Main()
			{

				// create an object of Queue class and perform the Queue operations.
				Queue q1 = new Queue();

				q1.Enqueue(10);
				q1.Enqueue(20);
				q1.Enqueue(30);
				q1.Enqueue(40);
				q1.Enqueue(50);
				q1.print_queue_elements();
				q1.dequeue();
				q1.dequeue();
				q1.print_queue_elements();
				q1.dequeue();
				q1.dequeue();
				q1.dequeue();
				q1.print_queue_elements();
				Console.ReadLine();
			
			}
		}
	}

}
