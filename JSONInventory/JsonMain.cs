using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JSONInventory
{
    public class JsonMain
    {
        Model Inventory = new Model();
        List<Model> Inventarylist = new List<Model>();

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
            }

        }
    }
}
