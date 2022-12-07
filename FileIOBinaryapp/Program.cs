using System.IO;
using System.Text;

string filePath = @"C:/Users/Pragati/oneDrive/Desktop/Test";

/*if(File.Exists(filePath))
{
    File.delete(filePath);
}
*/

//Creating new file(binay)and writing data inside

using (FileStream fs = File.Create(filePath)){
    string data = "This is Transflower data";
    UTF8Encoding endcoder = new UTF8Encoding(true);
    //string data is converted into
    byte []binaryData = endcoder.GetBytes(data);
    //binary data is written into file
    fs.Write(binaryData, 0 , binaryData.Length);
}

//now we would try code for reading data from binary file
//get stream in read mode
using (FileStream fs = File.OpenRead(filePath)){
    byte [] binaryData = new byte[1024];
    UTF8Encoding endcoder = new UTF8Encoding(true);
    while (fs.Read(binaryData,0 , binaryData.Length)> 0){
        //data which is in binary format is converted into string
        string dataFromFile = endcoder.GetString(binaryData);
        Console.WriteLine(dataFromFile);
    }
}
