
string[] list = File.ReadAllLines("../../../../Husdjuren.csv");

Dictionary<string, int> pets = new Dictionary<string, int>();

foreach (string word in list)
{
    string[] newList = word.Split(";"); // separerar orden som har ; emellan
    if (int.TryParse(newList[1], out int age)) // konverterar item på plats 2 till integer
    {
        pets.Add(newList[0], age); // lägger in listan i pets dictionary, assignar name och key value
    }
}

Console.WriteLine("Write a name");
var input = Console.ReadLine();


switch (pets.ContainsKey(input))
{
    
    case true:
        Console.WriteLine("Their birth year is: " + pets[input]);
        break;
    case false:
        Console.WriteLine("We don't have their information stored");
        break;
}