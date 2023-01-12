using System.Collections.Generic;

namespace HousingEstate
{
    public class Flat
    {
        private int _flatNumber;
        private int _area;
        private int _roomCount;
        private List<Person> _inhabitants = new List<Person>();

        public List<Person> Inhabitants
        {
            get => _inhabitants;
            set => _inhabitants = value;
        }
        public int FlatNumber
        {
            get => _flatNumber;
            set => _flatNumber = value;
        }

        public int Area
        {
            get => _area;
            set => _area = value;
        }

        public int RoomCount
        {
            get => _roomCount;
            set => _roomCount = value;
        }

        public Flat(int flatNumber, int area, int roomCount)
        {
            this._flatNumber = flatNumber;
            this._area = area;
            this._roomCount = roomCount;
        }
        
        
        

        public override string ToString()
        {
            return string.Format(
                $"Flat number: {FlatNumber} \nFlat Area: {Area} \nNumber of rooms: {RoomCount}");
        }
    }
}