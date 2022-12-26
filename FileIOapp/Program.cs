using System.IO;
using System.Text;
string filePath=@"C:\Users\Pragati\OneDrive\Desktop\Menu";


    if(File.Exists(filePath))
{
    File.Delete(filePath);
}
//Exception Handling
try{
    //Text Writing
    using(TextWriter writer = File.CreateText(filePath))
    {
        string data = "My name is pragati";
        Console.WriteLine(data);
    }
    //Text Reading
    using(TextReader reader = File.OpenText(filePath))
    {
        string data = reader.ReadToEnd();
        Console.WriteLine(data);
    }
}
catch (Exception e){
    Console.WriteLine(e.Message);
}