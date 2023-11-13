// using FirstApp.num;

// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Enter your number :" );
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("number is:" + n);


// Console.WriteLine("Enter your number :" );
// int n = int.Parse(Console.ReadLine());
// if(n>0){
//    Console.WriteLine(" your number is positive"); 
// }
// else if(n<0){
//     Console.WriteLine(" your number is negative"); 
// }
// else{
//     Console.WriteLine("zero"); 
// }

// Console.WriteLine("Enter your number :" );
// int n = int.Parse(Console.ReadLine());
// string result=(n>0) ?"positive":"negative";
// Console.WriteLine(result );







// sum of digits
// Console.WriteLine("The number is:");
// int num=int.Parse(Console.ReadLine()); //1234
// int sum =0;

// while(num!=0){
//     sum += num % 10;
        //  1234%10=4          123%10           12%10            1%10
                           //  3             // 2             // 1
    // sum=4                  sum=4+3=7         sum=4+3+2=9     sum=4+3+2+1=10
    // num = num/10;            
        //1234/10             123/10            12/10           1%10
    // num=123                 12               1               0.1

// }

// Console.WriteLine("sum of digits:" + sum);
// return 0;

// int num =int.Parse(Console.ReadLine());
// Number number = new Number();
// number.GetSum(num);
// Console.WriteLine("The number is:");
//8765

// int reverse=0;
// int rem;

// while(number!=0){
//     rem=number%10;
    // 8765%10           876%10          87%10              8%10
    // rem=5             rem=6           rem=7              rem=8
    // reverse=reverse*10+rem;
       //0*10+5=5        5*10+6=56       56*10+7=560+7=567  567*10+8=5678
    // number/=10;
    // 8765/10=876;      876/10=87       87/10=8            8/10=0.8
// }
// Console.WriteLine("reversed number:" + reverse);

// static void ShowFibonacciSeriesNumber(int level)
// {
//     int firstNumber = 0;
//     int secondNumber = 1;
//     Console.Write(firstNumber + " , " + secondNumber + " , ");
//     int sum;
//     for (int i = 2; i < level; i++)
//     {
//         sum = firstNumber + secondNumber;
//         firstNumber = secondNumber;
//         secondNumber = sum;
//         Console.Write(secondNumber + ", ");
//     }
// }

// ShowFibonacciSeriesNumber(5);


// static bool IsAbundant(int number)
// {
//     int sum=0;
//     for(int i=1;i<number; i++){
//         if(number%i==0){
//         sum+=i;
//         }
//     }
//         if(sum>number)
//         {
//            return true;
//         } 
//         return false; 
//     }
// bool status=IsAbundant(5);
// Console.WriteLine(status);


// static bool IsPrime(int n){
//  for(int i=2; i<n ; i++){
//     if(n%i==0){
//         return false;
//     }
//  }
//  return true;
// }

// bool status=IsPrime(10);
// if(status){
// Console.WriteLine("given number is prime number");
// }
// else{
//    Console.WriteLine("given number is not prime number"); 
// }



// static bool IsPrime(int n){
//     int count = 0;

//     // 0, 1 negative numbers are not prime
//     if(n < 2)
//         return false;

//     for(int i=2; i<n ; i++){
//     if(n%i==0){
//         return false;
//     }
// }
// return true;
// }

// // bool status=IsPrime(10);
// int lower =1;
// int upper =100;
// for(int i=lower; i<=upper ; i++){
//   if(IsPrime(i));
//   Console.WriteLine(i);

// }

//Abundant number
// static bool IsAbundant(int number){
// int sum=0;
// for(int i=1; i<number; i++){
//   if(number%i==0){
//     sum+=number;
//   }
//   if(sum>number){
//     return true;
//   }
// }
// return false;
// }

// bool status=IsAbundant(2);
// Console.WriteLine(status);

static bool prime_or_not(int a)
{
    int i;
    bool is_prime = true;
    if (a == 0 || a == 1)
    {
        is_prime = false;
    }
    for (i = 2; i <= a / 2; ++i)
    {
        if (a % i == 0)
        {
            is_prime = false;
            break;
        }
    }
    return is_prime;
}

bool status=prime_or_not(11);
Console.WriteLine(status);