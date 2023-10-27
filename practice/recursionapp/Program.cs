// using System.Runtime.InteropServices;

//last non-zero digit in factorial

// static int factorial(int n){
//     if(n<=1)
//     return 1;
//     return n*factorial(n-1);
// }

// int n =5;
// int fact = factorial(n);
// while(fact%10==0){
//    fact/=10;
// }
// Console.WriteLine(fact%10);

// Smallest Element of  the array using Recursion 
static int SmallestNumber(int number,int[] arr){
if(number==1)
return arr[0];
return Math.Min(arr[number-1], SmallestNumber(number-1, arr));
}
int[] arr={10,2,3,4,5,9};
int number = arr.Length;
Console.WriteLine("Smallest Element is: "+ SmallestNumber(number, arr));



// MaxValue is a constant that represents the maximum possible value for numeric data types such as integers. It is defined as a field in the System namespace under various numeric types like int, long, float, double, and so on. 

// MaxValue provides the largest value that can be stored in a particular data type.

// For example, in the case of int, you can access its maximum value using int.MaxValue. This value represents the largest positive integer that can be stored in an int variable in C#.

// Find smallest element in array
//   static int SmallestNumber(){
//   int[] numbers = { 34, 4, 89, 90, 56};
//   int n = numbers.Length;
//   int mini = int.MaxValue;

//   for(int i=0; i<n; i++){
//     if(numbers[i]<mini)
//       mini = numbers[i];
//   }
//     return mini;
//   }

// int m = SmallestNumber();
// Console.WriteLine(m);


// GetReverseNumber
// static int GetReverseNumber(int number)
// {
//     int reverse = 0;
//     int reminder;
//     while (number != 0)
//     {
//         reminder = number % 10;
//         reverse = reverse * 10 + reminder;
//         number /= 10;
//     }
//     return reverse;
// }
// int reverseNum = GetReverseNumber(1234);
// Console.WriteLine(reverseNum);

// Finding the longest number in an array
// static int FindLongestPalindrome(){


//   int[] number ={121,454,989,1271};
//   int n = number.Length;
//   int max =int.MinValue;

//   for(int i=0; i<n; i++){
//     if(number[i]>max)
//     max=number[i]; 
//   }
//   return max;
// }

// int palindrome = FindLongestPalindrome();
// Console.WriteLine(palindrome);

// Finding the longest palindrome number in an array
// static int FindLongestPalindrome(){

//   int IsPalindrome(int number){
//     int reverse=0;
//     int remainder;

//   while(number>0){
//     remainder= number%10;
//     reverse = reverse*10+remainder;
//     number =number/10;
//   }
//   if(number==reverse)
//   return 1;

//   return 0;
//   }
//   int[] number ={124,374,989,1221};
//   int n = number.Length;
//   int maxPalindrome =-1;

//   for(int i=0; i<n; i++){
//     if(IsPalindrome(number[i])==1 && maxPalindrome<number[i])
//     {
//     maxPalindrome=number[i]; 
//     }
//   }
//   if (maxPalindrome == -1)
//     {
//         Console.WriteLine("No palindromic numbers found.");
//     }
//     else
//     {
//         Console.WriteLine("The longest palindromic number is: " + maxPalindrome);
//     }
//   return maxPalindrome;
// }

// int palindrome = FindLongestPalindrome();
// Console.WriteLine(palindrome);


// static int FindLongestPalindrome()
// {
//     int IsPalindrome(int number)
//     {
//         int reverse = 0;
//         int temp = number; // Store the original number for comparison

//         while (number > 0)
//         {
//             int remainder = number % 10;
//             reverse = reverse * 10 + remainder;
//             number = number / 10;
//         }

//         return temp == reverse ? 1 : 0;
//     }

//     int[] numbers = { 124, 374, 1551, 1221 };
//     int n = numbers.Length;
//     int maxPalindrome = -1; // Initialize with -1 as there may not be any palindromes

//     for (int i = 0; i < n; i++)
//     {
//         if (IsPalindrome(numbers[i]) == 1 && numbers[i] > maxPalindrome)
//         {
//             maxPalindrome = numbers[i];
//         }
//     }

//     if (maxPalindrome == -1)
//     {
//         Console.WriteLine("No palindromic numbers found.");
//     }
//     else
//     {
//         Console.WriteLine("The longest palindromic number is: " + maxPalindrome);
//     }

//     return maxPalindrome;
// }

// int palindrome = FindLongestPalindrome();
//  Console.WriteLine(palindrome);



// static bool IsLowerCase(char c){
//   return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
// }

// static bool IsUpperCase(char c){
//   return (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');
// }

// char c ='p';
// if(IsLowerCase(c) || IsUpperCase(c)){
//   Console.WriteLine( c  + " is a vowel");
// }
// else if(!char.IsLetter(c)){
//    Console.WriteLine( "Non alphabate");
// }

// else{
//    Console.WriteLine( c +" is a consonent");
// }









// char[] characters=['a','e','i','o','u'];
// char[] values=['a','e','i','o','u'];




// Define an array of lowercase and uppercase vowels
// char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
// char character = 'f';

// Check if the character is in the array of vowels
// if (Array.IndexOf(vowels, character) != -1)
// {
//     Console.WriteLine("\n" + character + " is a vowel.");
// }
// else
// {
//     Console.WriteLine("\n" + character + " is a consonant.");
// }



// static int FindSum(string str){
//   int sum =0;
//  foreach(char ch in str){
//   if(char.IsDigit(ch)){
//     sum+= ch-'0';
//   }
//  }
//  return sum;
// }
// string str ="2dg5ds46";

// int sum = FindSum(str);
// Console.WriteLine(sum);


// Find the union and intersection of two sorted arrays
// static List<int> FindUnion(int[] number1,int[] number2){
  
//   List<int> union=new List<int>();
//   int i =0;
//   int j=0;
//   while(i<number1.Length && j<number2.Length){
//     if(number1[i]>number2[j]){
//       union.Add(number1[i]);
//       i++;
//     }
//     else if( number1[i]<number2[j]){
//       union.Add(number2[j]);
//       j++;
//     }
//     else{
//       union.Add(number2[j]);
//       i++;
//       j++;
//     }
//   }
//   while(i<number1.Length){
//     union.Add(number1[i]);
//       i++;
//   }
//   while(j<number2.Length){
//     union.Add(number2[j]);
//       j++;
//   }
// return union;
// }

// static List<int> FindIntersection(int[] number1,int[] number2){
  
//  List<int> intersection =new List<int>();
//  int i=0;
//  int j=0;
//  while(i < number1.Length && j < number2.Length){
//   if(number1[i]>number2[j]){
//     intersection.Add(number1[i]);
//     i++;
//   }
//   else if(number1[i]<number2[j]){
//     j++;
//   }
//   else{
//     intersection.Add(number1[i]);
//     i++;
//     j++;
//   }
// }
// return intersection;
// }

// int[] number1 ={1,3,5,8};
// int[] number2 ={1,3,6,7,9};

// List<int> intersectionResult = FindIntersection(number1,number2);
// List<int> unionResult = FindUnion(number1,number2);
// Console.WriteLine("intersection :"+ string.Join(",",intersectionResult));
// Console.WriteLine("union :"+ string.Join(",",unionResult));





 

//  static bool findSum(int[] numbers){
//  int flag=0;
//  int sum=0;
//  for(int i=0; i<numbers.Length; i++){
//   for(int j=i ;j<numbers.Length; j++ ){
//     sum+=numbers[j];
//     if(sum==0){
//       flag=1;
//       break;
//     }
//     else{
//       flag=0;
//       break;
//     }
//   }
//  }
//   if(flag==1){
//     return true;
//   }
//   return false;
//  }

// int[] numbers ={0,0,9,8,7};


// bool status = findSum(numbers);
// Console.WriteLine(status);
 

// int[] arr = { 10, -20, -30, 0, 70, -80, -20 };
//     int n= arr.Length;
//     int result = arr[0];
    
//     for (int i = 0; i < n; i++)
//     {
//         int mul = arr[i];
//         // traversing in current subarray
//         for (int j = i + 1; j < n; j++) { // updating result every time // to keep an eye over the // maximum product 
//                 if(mul>result)
//                 result = mul;
//             mul *= arr[j];
//         }
//         if(mul>result)
//             result = mul;
//     }
    
//     Console.WriteLine(result);

