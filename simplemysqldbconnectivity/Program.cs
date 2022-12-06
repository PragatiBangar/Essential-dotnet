//Third party packages
//downloading using dotnet add package command
// dotnet add package mysql.data

//steps for simple database connectivity in .net core application
//1.Create simple donet core console application using dotnet new command
//2.Download mysql.data package from internet using dotnet add package mysql.data
//3.Import Mysql.Data.MySqlClient namespace into Program.cs file
//4.
using MySql.Data.MySqlClient;

string conStr = "server=localhost; uid=root; password=Password; database=classicmodels";
MySqlConnection con = new MySqlConnection();

try{
    con.ConnectionString = conStr;
    con.Open();
    string query = "SELECT * FROM Employees";
    MySqlCommand cmd = new MySqlCommand(query, con);
    MySqlDataReader rdr = cmd.ExecuteReader();

    while (rdr.Read())
    {
        Console.WriteLine(rdr[0]+"--"+rdr[1]+"--"+rdr[2]+"--"+rdr[3]);
    }
    rdr.Close();
}
catch(Exception ee){
    Console.WriteLine(ee.Message);
}
finally{
    con.Close();
}





