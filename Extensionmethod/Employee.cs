public static class Employee{

    public static string name = "vedant";

    public static int x=20;

    public static string EmployeeDetails(this Student s){
        Console.WriteLine("My name is" +" "+name);
        return name;
    }

    public static int GetData(this Student s,int x){
        return x;
    }
}