using System;

namespace Inventory_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory_Management.JsonMain json = new Inventory_Management.JsonMain();
            json.convert("E:\\C#Assignments only program here\\Day_11_Object Oriented Programs\\Inventory Management\\Inventory.json");
        }
    }
}
