using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CalendarDbApp_ADB
{
    public class DbInteract
    {
        private MongoClient client;
        public IMongoCollection<BsonDocument> CurrentCollection { get; private set; }

        public DbInteract()
        {
            client = new MongoClient("mongodb://localhost:27017");

            CurrentCollection = client.GetDatabase("calendar").
                GetCollection<BsonDocument>("events_test");
            //WriteManyRandomEvents();
        }

        private void WriteManyRandomEvents()
        {
            Random rand = new Random();
            List<BsonDocument> documents = new List<BsonDocument>();
            for(int i = 0; i < rand.Next(200, 1000); i++)
            {
                documents.Add(new BsonDocument()
                {
                    {
                        "event_title",
                        Values.EventList[rand.Next(1000) % Values.EventList.Length] +
                        " with " +
                        Values.NamesList[rand.Next(1000) % Values.EventList.Length]
                    },
                    {
                        "event_start",
                        new BsonDateTime(new DateTime(2018, 2, rand.Next(1,28)))
                    }
                });
            }

            CurrentCollection.InsertMany(documents);
        }

        
    }

    public static class Values
    {
        public static string[] EventList =
        {
            "Dinner",
            "Lunch",
            "Breakfast",
            "Meeting",
            "Date",
        };
        public static string[] NamesList =
        {
            "Zak",
            "Jonelle",
            "Laverna",
            "Pansy",
            "Jazmin",
            "Daysle",
            "Clarita",
            "Donn",
            "Danyell",
            "Valeri",
            "Harris",
            "Anjelica",
            "Paul",
            "Katerine",
            "Pinkie",
            "Joetta",
            "Bronwyn",
            "Quiana",
            "Joie",
            "Elia",
            "Jonell",
            "Madelaine",
            "Melodi",
            "Arnette",
            "Ruthann",
            "Alishia",
            "Jimmy",
            "Hildegard",
            "Cliff",
            "Sandi",
            "Angie",
            "Oliva",
            "Vernie",
            "Luigi",
            "Trevor",
            "Bradford",
            "Emery",
            "Jeniffer",
            "Pedro",
            "Gemma",
            "Gilma",
            "Bobbye",
            "Jolanda",
            "Leone",
            "Alvina",
            "Corie",
            "Preston",
            "Vernita",
            "Kiersten",
            "Carmine",
            "Genaro",
        };
    }
}


