using System.Collections.Generic;

namespace HousingEstate
{
    public class Flat
    {
        public List<Person> Inhabitants { get; set; } = new List<Person>();

        private int FlatNumber { get; set; }
        private int Area { get; set; }
        private int RoomCount { get; set; }

        public Flat(int flatNumber, int area, int roomCount)
        {
            this.FlatNumber = flatNumber;
            this.Area = area;
            this.RoomCount = roomCount;
        }
        public void AddInhabitant(Person inhabitant)
        {
            Inhabitants.Add(inhabitant);
        }
        public override string ToString()
        {
            return string.Format(
                $"Flat number: {FlatNumber} \nFlat Area: {Area} \nNumber of rooms: {RoomCount}");
        }
    }
}