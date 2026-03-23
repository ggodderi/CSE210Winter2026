class Program
{

    public static void ProcessPerson(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());

        // if (person is Police police)
        // {
        //     Console.WriteLine(police.GetPoliceInformation());
        // }
        // else if (person is Doctor doctor)
        // {
        //     Console.WriteLine(doctor.GetDoctorInformation());
        // }
        // else
        // {
        //     Console.WriteLine(person.GetPersonInformation());
        // }

    }
    public static void Main(string[] args)
    {
        Person person = new Person("Bob", "Ross", 55, 195);

        // Console.WriteLine(person.GetPersonInformation());

        Doctor myDoctor, myDoctor2;

        myDoctor = new Doctor("Ax", "Bob", "Budge", 75, 210);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        myDoctor2 = new Doctor("Knife", "Bobby", "Billy", 75, 210);
        // Console.WriteLine(myDoctor2.GetDoctorInformation());

        Police myPolice = new Police("Gun", "Lance", "Bob", 43, 198);
        // Console.WriteLine(myPolice.GetPoliceInformation());

        // Doctor myDoctor3 = new Police("gun", "Bob", "bob", 23, 234);

        myPolice.SetWeight(myPolice.GetWeight() + 5);
        myPolice.SetAge(myPolice.GetAge() + 1);
        // Console.WriteLine(myPolice.GetPoliceInformation());


        List<Person> myPeople = new List<Person>();
        myPeople.Add(person);
        myPeople.Add(myDoctor);
        myPeople.Add(myDoctor2);
        myPeople.Add(myPolice);

        foreach(Person tempPerson in myPeople)
        {
            // Console.WriteLine(tempPerson.GetPersonInformation());
            ProcessPerson(tempPerson);
        }

    }
}