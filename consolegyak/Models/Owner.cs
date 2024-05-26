using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace consolegyak.Models
{
    public class Owner
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public string address { get; private set; }

        public Owner(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public static List<Owner> LoadFromJson(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string jsonAsString = sr.ReadToEnd();
            return JsonSerializer.Deserialize<List<Owner>>(jsonAsString);
        }


    }

}
