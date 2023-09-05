public class Book{

    public string BookName{get;set;}

    public string Author{get;set;}

    public Book(string bookName,string author){
        this.BookName=bookName;
        this.Author=author;
    }

    public void GetBookDetails(){
        Console.WriteLine(BookName+ " "+Author);
    }

    public void GetBookName(){
        Console.WriteLine(BookName);
    }
}