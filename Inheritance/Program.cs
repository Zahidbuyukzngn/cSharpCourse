namespace Inheritance //KALITIM
    //interface e çok benziyor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName="Engin"

                }, new Student
                {
                    FirstName="Naz"
                },new Person
                {
                    FirstName="Salih"
                }
                };
            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }



        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    // :Person dedikten sonra başka inheritance ekleyemiyoruz.İnterface de ekleyebiliyoruz , koyarak.
    //eğer eklemek istersek bir interface tanımlayıp onu inheritancenin yanına eklleyebiliyoruz
    class Customer :Person
    {
        public string City { get; set; }
    }
    class Student :Person
    {
        public string Department { get; set; }
    }

}
