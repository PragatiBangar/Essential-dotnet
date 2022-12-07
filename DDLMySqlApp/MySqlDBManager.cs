using MySql.Data.MySqlClient;

namespace DAL;
//Data Access Logic 
//Data Manipulation Logic
//Data Table creation logic

//Class is used to define reusable functions  for CRUD Operations against Students table
public static class MySqlDBManager{

    public static string conString = "server=localhost; user=root; database=classicmodels; password=Password ";

    public static bool CreateTable(){
        //code for creating table student
        bool status = false;

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try{
            /*DDL command*/
            string query = "CREATE TABLE students(studentid INT NOT NULL PRIMARY KEY AUTO_INCREMENT,"+
                           "firstName VARCHAR(25),"+
                           "lastName VARCHAR(55),"+
                           "qualification VARCHAR(55)"+
                           ")";
            Console.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            status = true;
        }
        catch(Exception ee){
            Console.WriteLine(ee.Message);
        }
        finally{
            con.Close();
        }
            return status;
    }
    public static bool Insert(string fname, string lname, string qual){

        bool status = false;

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try{
            /*DDL command*/
            string query = "INSERT INTO students(firstName, lastName, qualification) values('"+fname+ "', '" + lname + "', '" + qual + "')";
            Console.WriteLine(query);

            MySqlCommand cmd = new MySqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            status = true;
        }
        catch(Exception ee){
            Console.WriteLine(ee.Message);
        }
        finally{
            con.Close();
        }
             return status;
    }
    public static bool Update(int id, string fname, string lname, string qual){

        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try{
            /*update command*/
            string query = "Update students SET firstName='"+ fname + "'" +
                           "lastName = '"+lname+"'"+
                           "qualification='"+qual+"'"+
                           "WHERE studentid = "+id;
             Console.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            status= true;
        }
        catch(Exception ee){
             Console.WriteLine(ee.Message);
        }
        finally{
            con.Close();
        }
        return status;
    }
    public static bool Delete(int id){

        bool status = false;

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try{
            //update command
            string query ="Delete from students WHERE studentID= "+id;
            Console.WriteLine(query);
            MySqlCommand cmd =new MySqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            status = true;
        }
        catch(Exception ee){
            Console.WriteLine(ee.Message);
        }
        finally{
            con.Close();
        }
        return status;
    }
    public static void ShowAllStudents(){
        MySqlConnection con = new MySqlConnection();
        try{
            con.ConnectionString = conString;
            con.Open();
            string query = "SELECT * FROM students";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                //Console.writeLine(rdr[0]+"--"+rdr[1]+"--"+rdr[2]);
                Console.WriteLine(rdr["studentID"]+"--"+ rdr ["firstName"]+"--"+rdr["lastName"]+"--"+rdr["qualification"]+"')");
            }
            rdr.Close();
        }
        catch(Exception ee){
            Console.WriteLine("Exception : "+ ee.Message);
        }
        finally{
            con.Close();
        }
    }
    public static void ShowStudentBtId(int id){

        bool status = false;
        MySqlConnection con = new MySqlConnection();
        try{
            con.ConnectionString = conString;
            con.Open();
            string query = "SELECT * FROM students WHERE studentId='+id'";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                Console.WriteLine(rdr["studentId"]+"--"+rdr["firstName"]+"--" +rdr["lastName"]+"--"+rdr["qualification"]+"')");
                status = true;
            }
            rdr.Close();
        }
        catch(Exception ee){
            Console.WriteLine("Exception : "+ ee.Message);
        }
        finally{
            con.Close();
        }
    }
}   
