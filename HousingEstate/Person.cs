namespace HousingEstate
{
    public class Person
    {
        private string Naming { get; set; }

        private string Surnaming { get; set; }

        private int Ageing { get; set; }

        public Person(string name, string surname, int age)
        {
            this.Naming = name;
            this.Surnaming = surname;
            this.Ageing = age;
        }
        

            public override string ToString()
             {
                  return string.Format(
                $"Name: {Naming} \nSurname: {Surnaming} \nAge: {Ageing}");
             }
        
    }
}
