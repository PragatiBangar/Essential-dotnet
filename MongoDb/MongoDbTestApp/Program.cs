using System;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbTestApp
{
    public class Students
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id{get ; set ;}

        public string firstname{get ; set ;}

        public string lastname{get ; set ;}

        public string education{get ; set ;}
    } 
    class program 
    {
        static void Main(string[] args)
        {
            List<Students> list = new List<Students>();  // mongodb://localhost:27017/
            var _mongoClient = new MongoClient("mongodb://localhost:27017/");
            var db = _mongoClient.GetDatabase("transflower");

            var collection = db.GetCollection<Students>("students");
            collection.Find(_=>true).ToList().ForEach(
                students=>{
                    Console.WriteLine(students.firstname);
                    Console.WriteLine(students.lastname);
                    Console.WriteLine(students.education);
                }
            );
        }
    }

}
