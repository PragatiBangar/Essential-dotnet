using System;

namespace NumberOperation;

    public static class ReverseNumber{

        static int reverse;
        static int rem=0;
        
        public static int GetReverseNum(int num){
        while(num!=0){
        rem=num%10;
        // 8765%10           876%10          87%10              8%10
        // rem=5             rem=6           rem=7              rem=8
        reverse=reverse*10+rem;
       //0*10+5=5        5*10+6=56       56*10+7=560+7=567  567*10+8=5678
        num/=10; 
        }
        return reverse;
    }
  }  
