using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            var inhabitant = new Person("Michal", "Bernát", 16);
            Console.Write(inhabitant.ToString());
        }
    }
}