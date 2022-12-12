using System;

namespace JSONInventory
{
    public class Program
    {
        static void Main(string[] args)
        {
            JSONInventory.JsonMain json = new JSONInventory.JsonMain();
            json.convert("E:\\C#Assignments only program here\\Day_11_Object Oriented Programs\\JSONInventory\\Inventary.json");
            
        }
    }
}
