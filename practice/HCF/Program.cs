//Highest Common Factor(HCF)

// int num1 = 12;
// int num2 = 36;
// int HCF = 1;

// for(int i=1; i<=num1 && i<=num2; i++ ){
//     if(num1%i==0 && num2%i==0){
//         HCF=i;
//     }
// }
// Console.WriteLine(HCF);



// quadrants in which a given coordinates lies

static void quadrants(int x,int y){
if(x>0 && y>0){
   Console.WriteLine("point: " + x +"," +y+" lies in the first quadrant");
}
else if(x<0 && y>0){
   Console.WriteLine("point: " + x +"," +y+" lies in the second quadrant");
}
else if(x<0 && y<0){
   Console.WriteLine("point: " + x +"," +y+" lies in the third quadrant");
}
else if(x>0 && y<0){
   Console.WriteLine("point: " + x +"," +y+" lies in the forth quadrant");
}
else if(x==0 && y==0){
   Console.WriteLine("point: " + x +"," +y+" lies in origin");
}
else if(x!=0 && y==0){
   Console.WriteLine("point: " + x +"," +y+" lies in x-axis");
}
else if(x==0 && y!=0){
   Console.WriteLine("point: " + x +"," +y+" lies in y-axis");
}
}
int o=quadrants(1,2);
Console.WriteLine(o);

// Calculate the number of digits in an integer

// Console.WriteLine("number is:");
// int num =int.Parse(Console.ReadLine());
// int digit =0;
// while(num>0){
//     digit++;
//     num=num/10;
// }
// Console.WriteLine("size of integer is:"+digit);

static int GetCountOfDigits(int number){
int digit=0;
   while(number>0){
    digit++;
    number=number/10;
}
    return digit;
}

int pb = GetCountOfDigits(12);
Console.WriteLine(pb);
