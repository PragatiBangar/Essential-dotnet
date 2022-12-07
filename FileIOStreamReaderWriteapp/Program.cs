using System.IO;

string filePath = @"C:/Users/Pragati/oneDrive/Desktop/Format";
//File content writing
FileStream fs = new FileStream(filePath ,FileMode.Create);
using(StreamWriter sw = new StreamWriter(fs)){
    sw.WriteLine("welcome to home");
    sw.WriteLine("\n a learning experience");
    sw.WriteLine("\n doing ordinry things");
}

//reading file content
using (StreamReader sr = new StreamReader(filePath)){
    string txt;
    //Read data from file, until the end of file is reached
    while ((txt = sr.ReadLine())!= null){
        Console.WriteLine(txt);
    }
}