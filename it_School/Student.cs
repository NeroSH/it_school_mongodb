using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Runtime.Serialization;

namespace it_School
{
    
    class Student
    {
        //[BsonId]
        public ObjectId _id { get; set; }
        //[BsonElement("pid_student")]
        public int pid_student { get; set; }
        //[BsonElement("s_surname")]
        public string s_surname { get; set; }
        //[BsonElement("s_name")]
        public string s_name { get; set; }
        //[BsonElement("s_patronymic")]
        public string s_patronymic { get; set; }
        //[BsonElement("phone_number")]
        public Int64 phone_number { get; set; }
        //[BsonElement("date_of_birth")]
        public string date_of_birth { get; set; }
        //[BsonElement("description")]
        public string description { get; set; }
        //[BsonElement("gender")]
        public string gender { get; set; }
        //[BsonElement("pc")]
        public bool pc { get; set; }
        //[BsonElement("payment")]
        public bool payment { get; set; }

    }
}
