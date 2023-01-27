using System;
using System.Threading;

namespace SimpleConsoleApp
{
    //Multithreaded Application
    class Program
    {
        //need to execute both functions is independent manner
        static void StoreData(){
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("StoreData fn Thread=" +theThread.ManagedThreadId);
            Console.WriteLine("Storing data into JSON file");
            Thread.Sleep(3000);
            Console.WriteLine("Data is successfully written in file JSON ");
        }
        static void GetRemoteData(){
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("GetRemoteData fn Thread=" +theThread.ManagedThreadId);
            Console.WriteLine("Getting users data from git repository");
            Thread.Sleep(4000);
            //access data from external applications using RPC
            Console.WriteLine("Data is received from Remote Server ");
        }

        static void Main(string[] args)
        {  
            //Primary Thread
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("Main function invoker =" +theThread.ManagedThreadId);
            Thread.Sleep(5000);
            Display();
            
            //Creating two secondary threaded using .Net sdk
            ThreadStart theDelegate1 = new ThreadStart(StoreData);
            Thread thread2 = new Thread(theDelegate1);

            ThreadStart theDelegate2 = new ThreadStart(GetRemoteData);
            Thread thread3 = new Thread(theDelegate2);

            thread2.Start();
            thread3.Start();

            Console.WriteLine("Main fn is about to be terminated.....");
        }
        public static void Display(){
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("Display fn Thread=" + theThread.ManagedThreadId);
            Console.WriteLine("Displaying product catalod data");
        }
    }
}