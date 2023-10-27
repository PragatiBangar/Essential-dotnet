using System;

namespace NumberOperation;

    public static class PrimeNumber{
    //     static int number1 =1;
    //     static int number2=10;

        
    public static bool isPrime(int n){

        for(int i=number1; i<=number2; i++){
            if(isPrime(i))
            Console.WriteLine(i);

        }
        if(n<2)
        return false;

        for(int i=2; i<n; i++){
            if(n%i==0)
            return false;
        }
        return true;
    }

       static int lower = 1;
       static int upper = 100;
       for (int i = lower; i <= upper; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }

   
}
    
    
        
