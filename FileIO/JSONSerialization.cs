using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Json.Net;
using Newtonsoft.Json;
namespace FileIODemo
{
    public class JSONSerialisation
    {
        public void JsonSerialization()
        {
            BlogSites blogSites = new BlogSites()
            {
                Name = "Sam",
                Description = "Welcome"
            };

            string jsonData = JsonConvert.SerializeObject(blogSites);
            Console.WriteLine(jsonData);
        }
        public void JsonDeserialization()
        {
            string json = @"{'Name':'Sam','Description':'Welcome'}";

            BlogSites blogSites = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(blogSites.Name);
        }

    }
    [DataContract]
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }

}