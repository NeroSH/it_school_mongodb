using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_School
{
    class DBConnection
    {
        public static MongoClient client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
        // Название базы данных 
        public static IMongoDatabase School { get; } = client.GetDatabase("itSchool");
        // Коллекции MongoDB = Таблицы PostreSQL
        public static IMongoCollection<BsonDocument> Classroom     { get; set; } = School.GetCollection<BsonDocument>("classroom");
        public static IMongoCollection<BsonDocument> Contract      { get; set; } = School.GetCollection<BsonDocument>("contract");
        public static IMongoCollection<BsonDocument> Curriculum    { get; set; } = School.GetCollection<BsonDocument>("curriculum");
        public static IMongoCollection<BsonDocument> Equipement    { get; set; } = School.GetCollection<BsonDocument>("equipement");
        public static IMongoCollection<BsonDocument> Groups        { get; set; } = School.GetCollection<BsonDocument>("groups");
        public static IMongoCollection<BsonDocument> Parents       { get; set; } = School.GetCollection<BsonDocument>("parents");
        public static IMongoCollection<BsonDocument> Campus        { get; set; } = School.GetCollection<BsonDocument>("school");
        public static IMongoCollection<BsonDocument> Staff         { get; set; } = School.GetCollection<BsonDocument>("staff");
        public static IMongoCollection<BsonDocument> Students      { get; set; } = School.GetCollection<BsonDocument>("student");
        public static IMongoCollection<BsonDocument> Teachers      { get; set; } = School.GetCollection<BsonDocument>("teachers");
        
    }
}
