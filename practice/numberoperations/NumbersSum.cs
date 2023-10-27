using System;

namespace NumberOperation;

    public static class NumbersSum{
        static int sum =0;
        static int number;

    public static int GetSumOfNumbers(int number){

    while(number!=0){
    sum += number % 10;
        //  1234%10=4          123%10           12%10            1%10
                           //  3             // 2             // 1
    // sum=4                  sum=4+3=7         sum=4+3+2=9     sum=4+3+2+1=10
    number = number/10;            
        //1234/10             123/10            12/10           1%10
    // num=123                 12               1               0.1
     }
     return sum;
    }
  }
