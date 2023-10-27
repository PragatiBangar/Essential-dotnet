// using NumberOperation;

// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Enter your number:");
// int num =int.Parse(Console.ReadLine());
// int r = ReverseNumber.GetReverseNum(num);
// Console.WriteLine(r);

// Console.WriteLine("Enter your number:");
// int number =int.Parse(Console.ReadLine());
// int p = NumbersSum.GetSumOfNumbers(number);
// Console.WriteLine(p);

//  Console.WriteLine("Enter number:");
// int n =int.Parse(Console.ReadLine());
// bool p = PrimeNumber.isPrime(n);
// Console.WriteLine(p);


  static bool IsPrime(int n)
    {
        
        // 0, 1, and negative numbers are not prime
        if (n < 2)
            return false;

        // Checking divisors up to the square root of n
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
    int m =IsPrime(5);
    Console.WriteLine(m);



