using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace flowersMongoDbTestApp
{
    public class Flower
    {
        public ObjectId Id {get ; set;}

        public string title {get ; set;}

        public string colour {get; set; }

        public string days {get ; set;}
    }
    
    public class Program 
    {
        protected static IMongoClient client ;

        protected static IMongoDatabase database ;

        public static Flower GetFlower()
            {
                Console.WriteLine("Please enter flower title:");
                string title = Console.ReadLine();
                Console.WriteLine("Please enter flower colour:");
                string colour = Console.ReadLine();
                Console.WriteLine("Please enter flower days:");
                string days = Console.ReadLine();

                Flower flower = new Flower()
                {
                    title = title,
                    colour = colour,
                    days = days
                };
                return flower;
            }
        
        public static void CRUDwithMongoDb()
        {
            client = new MongoClient();
            database = client.GetDatabase("transflower");
            var collection = database.GetCollection<Flower>("flowers");

            Console.WriteLine("Press select your option from the following\n1 - Insert\n2 - UpdateOne Document\n3 - Delete\n4 - Read All\n");
            string userSelection = Console.ReadLine();

            switch(userSelection)
            {
                case "1":
                    //Insert
                    collection.InsertOne(GetFlower());
                    break;

                case "2":
                    //Update
                    var obj1 = GetFlower();

                    collection.FindOneAndUpdate<Flower>
                        (   Builders<Flower>.Filter.Eq("title", obj1.title),
                            Builders<Flower>.Update.Set("colour", obj1.colour).Set("days",obj1.days));
                    break;

                case "3" :
                //Find and Delete
                    Console.WriteLine("Please enter the title to delete the record(so called document) : ");
                    var deletetitle = Console.ReadLine();
                    collection.DeleteOne(s => s.title == deletetitle );
                    break;

                case "4":
                //Read all existing document
                    var all = collection.Find(new BsonDocument());
                    Console.WriteLine();

                foreach (var i in all.ToEnumerable())
                {
                    Console.WriteLine(i.Id +" "+i.title + "\t " + i.colour + "\t" + i.days);
                }
                break;

                default:
                    Console.WriteLine("Please choose a correct option");
                    break;
            }

            //To continue with program
            Console.WriteLine("\n--------------------------\nPress Y for continue...\n");
            string userChoice = Console.ReadLine();

            if (userChoice == "Y" || userChoice == "y")
            {
                CRUDwithMongoDb();
            }
        }

        static void Main (string[] args)
        {
            CRUDwithMongoDb();
            Console.WriteLine("Hello world");
        }
    }
}
