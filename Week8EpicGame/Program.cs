string DbFolderPath = @"C:\Data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";
string[] heroes = File.ReadAllLines(Path.Combine(DbFolderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(DbFolderPath, villainFile));

//string[] heroes = { "Batman", "Superman", "Ironman", "Wonder", "Flash" }; //RAW DATA
//string[] villains = { "Joker", "Lex", "Thanos", "Cheetah", "Zoom", "Rene" };
string[] weapon = { "sword", "gun", "laser", "hammer", "shield", "banana", "logo", "plastic spoon"};

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"But {villain} with {villainWeapon} is up to no good!");

static string GetRandomValueFromArray(string[] array)
{
    Random rnd = new Random();
    int index = rnd.Next(0, array.Length);
    return array[index];
}