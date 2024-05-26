using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace consolegyak.Models
{

   

    public class Car
    {
        public int id { get; private set; }
        public string brand { get; private set; }
        public string model { get; private set; }
        public DateTime registration_date { get; private set; }
        public int owner_id { get; private set; }

        public Car(int id, string brand, string model, DateTime registration_date, int owner_id)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.registration_date = registration_date;
            this.owner_id = owner_id;
        }

        public static  List<Car> LoadFromJson(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string jsonAsString = sr.ReadToEnd();
            return JsonSerializer.Deserialize<List<Car>>(jsonAsString);
        }
    }

}
