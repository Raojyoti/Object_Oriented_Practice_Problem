using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace Inventory_Management
{
    public class JsonMain
    {
        Model2 Inventory = new Model2();
        List<Model2> Inventarylist = new List<Model2>();
      
        public void convert(string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Model>>(json);
                Console.WriteLine("Name Weight Price Total Value");
                foreach (var item in items)
                {
                    double value = item.Price * item.Weight;
                    Console.WriteLine(item.Name + "   " + item.Weight + "   " + item.Price + "   " + value);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Name ");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Name );
                }

                Console.WriteLine("\n");
                Console.WriteLine("Price");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Price);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Weight");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Weight);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Name  Weight");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Name + " " + item.Weight);
                }
                Console.WriteLine("\n");
                Console.WriteLine("Name  Price ");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Name + " " + item.Price);
                }
            }
        }
    }
}
