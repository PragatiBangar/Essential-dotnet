﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleTaskApp
{
    //Single Threaded Application
     
    class Program
    {
        //non blocking call
        public static async Task StoreData()
        {
            //defining callback function and invoking callback function
            //using internal thread pool
            await Task.Run(()=>{
                Console.WriteLine("storing data to JSON file");
            });
        }
        public static async Task GetRemoteData()
        {
            await Task.Run(()=>{
                Console.WriteLine("getting data from external world");
            });
        }

        static void Main(string[] args)
        {
            //primary Thread:
            //is to invoke main entrypoint function

            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("Main fn Thread="+ theThread.ManagedThreadId);
            //Invoke other reusable function
            StoreData();
            GetRemoteData();
            Console.WriteLine("Hello World");
        }
    }
}
