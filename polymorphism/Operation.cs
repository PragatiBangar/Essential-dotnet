public class Operation{

//In method overloading a class contain same methods, this methods having different parameters.


    public void Add(){
        // return a+b;
        int a =30;
        int b =10;
        int c = a+b;
        Console.WriteLine(c);
    }

    public int Add(int a,int b,int c){
        return a+b+c;
    }
}