using OOPSmolyan2026;

class Program
{
    static void Main()
    {
        //string name = "Medina";
        //int age = 18;

        //string name2 = "Evgeni";
        Person person0 = new Person("Stoyan", 62);
        Person person1 = new Person("Medina", 18);
        Person person2 = new Person(19, "Evgeni");
        Person person3 = new Person(18, "Zara");   
        Person person4 = new Person("Yordanka", 18);
        Person person5 = new Person("Angelina", 18);
        Person person6 = new Person("Petya", 18);

        IIntroducable student1 = new Student("Kiril", 20, "FN12345");

        IIntroducable athlete1 = new Athlete("Maria", 25, "Tennis");

        //Console.WriteLine($"Person 1: {person1.GetName()}, Age: {person1.GetAge()}");
        //Console.WriteLine($"Person 2: {person2.GetName()}, Age: {person2.GetAge()}");

        person1.Introduce();
        person2.Introduce();
        person3.Introduce();
        person6.Introduce();
        Console.WriteLine("The population of my little kingdom is {0}", Person.Counter);
        Console.WriteLine("The national income of my little kingdom is {0}", Person.NationalIncome());
        Console.WriteLine("My nationality is {0}", person2.country);
        Console.WriteLine(Person.PI);

        student1.Introduce();
        athlete1.Introduce();
    }

    void Test()
    {
        Person person = new Person("Stoyan", 62);
        person.Introduce();
    }
}
