using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_11
{
    class Creator
    {
        public string creatorName;
        public byte creatorExpereience;
        static public Hashtable hashTable = new Hashtable();
        public Creator(string creatorName, byte creatorExpereience)
        {
            this.creatorName = creatorName;
            this.creatorExpereience = creatorExpereience;
        }

        static void CreateBuild(int BuildingID)
        {
            Building b = new Building(BuildingID);
            hashTable.Add(BuildingID,b);
            Console.WriteLine($"Здание {BuildingID} создано!");
        }
        static void CreateBuild(string name, int BuildingID, double BuildingHeight)
        {
            Building b = new Building(BuildingID);
            hashTable.Add(BuildingID, b);
            Console.WriteLine($"{name} построил здание {BuildingID} с высотой {BuildingHeight}");
        }
        
        static void RemoveBuild(int BuildingID)
        {
            hashTable.Remove(BuildingID);
        }

       
    }
}
