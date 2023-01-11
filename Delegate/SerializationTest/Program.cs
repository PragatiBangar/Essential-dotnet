using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SerializationTest
{


    [Serializable]
    public class Student
    {
        public int Id {get; set; }
        public string firstname{get; set; }
        public string lastname{get; set; }
        public string education{get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student theStudent = new Student();
            
            theStudent.Id = 12;
            theStudent.firstname = "Mayur";
            theStudent.lastname = "Gorade";
            theStudent.education = "BE Electrical";
        

            Student theStudent1 = new Student();
            
            theStudent1.Id = 12;
            theStudent1.firstname = "Pooja";
            theStudent1.lastname = "Divekar";
            theStudent1.education = "BE Electrical";
        

        List<Student> students = new List<Student>();
        
        students.Add(theStudent);
        students.Add(theStudent1);

        students.Add(new Student{Id = 12, firstname = "Yogita", lastname = "Jadhav", education = "BE Electrical"});
        students.Add(new Student{Id = 12, firstname = "Pushkar", lastname = "Bangar", education = "BE Mechanical"});
        students.Add(new Student{Id = 12, firstname = "Harshad", lastname = "Bangar", education = "BE Civil"});
        students.Add(new Student{Id = 12, firstname = "Lata", lastname = "Kokate", education = "BE E&TC"});
        
           foreach(Student student in students)
           {
           Console.WriteLine($" Student :{student.firstname}:{student.lastname}:{student.education}");
           }
           
           // Logic for serialization
           try
           {
               Stream stream = new FileStream("students.bin", FileMode.Create,
                                               FileAccess.Write,FileShare.None);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream,students);
                stream.Close();
           }
           catch(Exception exp)
           {

           }
           finally
           {

           }

           //Logic for deserialization
           Console.WriteLine("After Deserialization , retrieved products......");
           try
           {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("students.bin", FileMode.Open,
                                                FileAccess.Read, FileShare.Read);
                List<Student> studentsFromFile = (List<Student>)formatter.Deserialize(stream);
                foreach(Student student in studentsFromFile)
                {
                    Console.WriteLine($"{student.firstname}:{student.lastname}:{student.education}");
                }
           }
           catch(Exception exp)
           {

           }
           finally
           {

           }
        
           try
           {
                var options = new JsonSerializerOptions {IncludeFields = true};
                var studentsJson = JsonSerializer.Serialize<List<Student>>(students,options);
                string fileName = "students.json";
                File.WriteAllText(fileName,studentsJson);
           }
           catch(Exception exp)
           {

           }
           finally
           {

           }
            // Deserialization from Json file
            try
            {
                var options = new JsonSerializerOptions {IncludeFields = true};
                string fileName = "students.json"; 
                string jsonString = File.ReadAllText(fileName);

                List<Student> jsonStudents = JsonSerializer.Deserialize<List<Student>>(jsonString);
                Console.WriteLine("Deserializing data from json file");
                foreach( Student student in jsonStudents)
                {
                    Console.WriteLine($"{student.firstname}: {student.lastname}: {student.education}");
                }
            }

            catch(Exception exp)
            {

            }
            finally
            {

            }
        }
    }
}

