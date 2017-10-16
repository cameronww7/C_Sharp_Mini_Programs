using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue!");

            Queue myQueue = new Queue(5);
            myQueue.insert(100);
            myQueue.insert(10);
            myQueue.insert(20);
            myQueue.insert(30);
            myQueue.view();

            Console.WriteLine($"Front of queue is {myQueue.peekFront()} ");

            Console.WriteLine("About to remove item from queue");
            myQueue.remove();
            Console.WriteLine($"Front of queue is {myQueue.peekFront()} ");
            myQueue.view();
        }
    }

    public class Queue
    {
        private int maxSize; // of queue
        private long[] myQueue;
        private int front; // of queue
        private int rear; // of queue
        private int items; // in the queue

        public Queue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0;
        }

        public void insert(long j)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }
                rear++;
                myQueue[rear] = j;
                items++;
            }
        }

        public long remove()
        {
            long temp = myQueue[front];
            front++;
            if (front == maxSize)
            {
                front = 0;
            }

            // removes from the que
            for(int index = 0; index < maxSize-1; index++) {
                myQueue[index] = myQueue[index+1];
            }
            myQueue[maxSize-1] = 0;

            return temp;
        }

        public long peekFront()
        {
            return myQueue[front];
        }

        public bool isEmpty()
        {
            return (items == 0);
        }

        private bool isFull()
        {
            return (items == maxSize);
        }

        public void view() {
            Console.Write("[");
            for (int i = 0; i < myQueue.Length; i++)
            {
                Console.Write(myQueue[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}
