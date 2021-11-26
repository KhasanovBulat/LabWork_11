using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_11
{
    class Building
    {
        private int BuildingID;
        public static int currID = 1;
        private double BuildingHeight;
        private int Floors;
        private int FlatsNumber;
        private int SectionsNumber;

        internal Building()
        {
            BuildingID = currID;
            currID++;
        }
        
        internal Building(int BuildingID,double BuildingHeight)
        {
            this.BuildingID = BuildingID;
            this.BuildingHeight = BuildingHeight;
        }

        internal Building(int BuildingID)
        {
            this.BuildingID = BuildingID;
        }

        public void SetTheBuildingID(int buildingID)
        {
            BuildingID = buildingID;
        }

        public void SetTheHeight(double buildingHeight)
        {
            BuildingHeight = buildingHeight;
        }

        public void SetTheFloors(int floors)
        {
            Floors = floors;
        }

        public void SetTheFlatsNumber(int FlatsNumber)
        {
            this.FlatsNumber = FlatsNumber;
        }

        public void SetTheSectionsNumber(int SectionsNumber)
        {
            this.SectionsNumber = SectionsNumber;
        }

        public double CountFloorHeight()
        {
            return BuildingHeight / Floors;
        }

        public int CountFlatsInSection()
        {
            return FlatsNumber / SectionsNumber;
        }

        public int CountFlatsOnFloor()
        {
            int a = (FlatsNumber / SectionsNumber) / Floors;
            return a;
        }

        public override string ToString()
        {
            return $"ID дома: {BuildingID}, Высота здания: {BuildingHeight}, Количество этажей: {Floors}, Подъездов: {SectionsNumber}, Квартир в доме: {FlatsNumber}";
        }
        
    }
}
