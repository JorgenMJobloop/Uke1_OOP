namespace Uke1_OOP;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.x = 4;
        calculator.y = 5;
        Console.WriteLine(calculator.Power(calculator.x, calculator.x));
        Console.WriteLine(calculator.Add(5, 50)); // 55
        Console.WriteLine(calculator.Divide(5, 2)); // should fail if b is 0

        // List data structure

        List<string> videoGames = new List<string>();

        videoGames.Add("Skyrim");
        videoGames.Add("Helldivers");
        videoGames.Add("Limbo");
        videoGames.Add("Morrowind");
        videoGames.Add("Leauge of Legends");

        Console.WriteLine("A list of video games:");

        foreach (string games in videoGames)
        {
            Console.WriteLine(games);
        }

        List<string> handleListe = new List<string>() {
            "Melk",
            "Egg",
            "Kylling",
            "Biff",
            "Brød"
        };

        Console.WriteLine("My shopping list:");
        foreach (string elements in handleListe)
        {
            Console.WriteLine(elements);
        }

        Dictionary<int, string[]> myHashMap = new Dictionary<int, string[]>();

        myHashMap.Add(1, ["Hello", "LG"]);
        myHashMap.Add(2, ["Some", "more", "text"]);
        // Nested foreach loops
        foreach (var keyValuePairs in myHashMap)
        {
            // Console.WriteLine(keyValuePairs.Key);
            // // inner foreach loop
            foreach (var values in keyValuePairs.Value)
            {
                Console.WriteLine(values);
            }
            Console.WriteLine($"string: {keyValuePairs.Key}, int: {keyValuePairs.Value}");
        }

        Person person = new Person();
        person.Name = "Lars Prime";

        Person personTwo = new Person();
        personTwo.Name = "Lars Gunnar";

        List<Person> people = new List<Person>();
        people.Add(person);
        people.Add(personTwo);

        foreach (Person persons in people)
        {
            persons.SayHi();
        }
    }
}
