public class Book{

    public string BookName{get;set;}

    public string Author{get;set;}

    public Book(){
        this.BookName="clean";
        this.Author="pragati";
        // Console.WriteLine(BookName+" "+Author);
    }

    public void GetBookDetails(){
        Console.WriteLine(BookName+ " "+Author);
    }

    public void GetBookName(){
    }

    
}