public class Student{

    public string name = "pragati";
    public int score=30;
    public string GetName(){
        Console.WriteLine("My name is" +" "+name);
        return name;
    }

    public int GetDetails(){
        Console.WriteLine("My score is" +" "+score);
        return score;
    }
}