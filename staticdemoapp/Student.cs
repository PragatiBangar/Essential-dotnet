namespace Training;
public class Student{
     
    private int id;
    private string fullName;
    private string qualification;
    private string email;

    private static int count;

    public Student(){
        this.id=45;
        this.fullName="Nutan Navale";
        this.qualification="BE";
        this.email="nutan.navale@gmail.com";
        Console.WriteLine("constructor is called....");
        count=count+1;
    }

    public Student(int i,string name,string education){
        this.id=i;
        this.fullName=name;
        this.qualification=education;
        this.email="student.tfl@gmail.com";
        count=count+1;
    }
    public Student(int i,string name,string education,string em){
        this.id=i;
        this.fullName=name;
        this.qualification=education;
        this.email=em;
        count=count+1;
    }
    public override string ToString()
    {
        string data=string.Format("{0}, {1} ,{2}",
                                        this.id,this.fullName,this.qualification);
        return data;
    }

    public void ShowStatus(){
        Console.WriteLine("I am alive");
    }
    public static int GetCount(){
        return count;
    }
    }