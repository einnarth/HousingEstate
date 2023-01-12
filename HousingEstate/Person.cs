namespace HousingEstate
{
    public class Person
    {
        private string _name;
        private string _surname;
        private int _age;

        public string Naming
        {
            get => _name;
            set => _name = value;
        }

        public string Surnaming
        {
            get => _surname;
            set => _surname = value;
        }

        public int Ageing
        {
            get => _age;
            set => _age = value;
        }

        public Person(string name, string surname, int age)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
        }
        

            public override string ToString()
             {
                  return string.Format(
                $"Name: {Naming} \nSurname: {Surnaming} \nAge: {Ageing}");
             }
        
    }
}
