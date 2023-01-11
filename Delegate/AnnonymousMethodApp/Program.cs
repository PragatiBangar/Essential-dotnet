using System;

namespace AnnonymousMethodApp
{    
    //Declare Delegate type

    public delegate void BasicOperation();
    public delegate void DoSomething();
    public delegate int annonymousOperation1(int i);
    public delegate int annonymousOperation2(int a, int b);

    class Program
    {
        // Callback function

        void PrintReport(){
            Console.WriteLine("Printing a report: graph, table, score cards");
        }
        
        static void Main(string[] args)
        {
            //register the function
            //registering the callback function
            Program theProgram = new Program();
            BasicOperation method1 = new BasicOperation(theProgram.PrintReport);
            //resolving name of function at runtime
            method1();
            
            //Inline function
            //Annonymous method

            BasicOperation method2 = delegate(){
                Console.WriteLine("Printing company annual report");
            };
            method2();

            //lambda
            DoSomething method3 = () => { Console.WriteLine("Printing covid spread lockdown report");};
            method3();
            
            annonymousOperation1 method4 = new annonymousOperation1(
                                                                   delegate(int x){
                                                                       return
                                                                       x * 2;
                                                                   }
                                    );
            Console.WriteLine("{0}", method4(3));

            annonymousOperation1 method5 = x => x*2;    //use of lambda
            Console.WriteLine("{0}", method5(5));
            
            //(input parameters) => Expression;
            annonymousOperation2 getBigInteger = (x,y) => {if (x>y) return x; else return y;};
            Console.WriteLine(getBigInteger(20,25));
            
            // Which is the good language ?
            // Answer:The language which transforms itself over period as per 
            // the culture of society  transforms
        }
    }
}
