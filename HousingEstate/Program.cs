using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            var michal = new Person("Michal", "Bernát", 17);
            var zaso = new Person("Zachariáš", "Juriš", 17);
            var riso = new Person("Richard", "Jurčo", 17);
            //Console.WriteLine(michal.ToString());
            var michalovbyt = new Flat(666, 65, 3);
            michalovbyt.AddInhabitant(michal);
            michalovbyt.AddInhabitant(zaso);
            michalovbyt.AddInhabitant(riso);

            Console.WriteLine(michalovbyt.ToString());
            foreach (var inhabitant in michalovbyt.Inhabitants)
            {
                Console.WriteLine(inhabitant.ToString());
            }
        }
    }
}
    