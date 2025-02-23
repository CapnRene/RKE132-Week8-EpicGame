string DbFolderPath = @"C:\Data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";
string[] heroes = File.ReadAllLines(Path.Combine(DbFolderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(DbFolderPath, villainFile));

//string[] heroes = { "Batman", "Superman", "Ironman", "Wonder", "Flash" }; //RAW DATA
//string[] villains = { "Joker", "Lex", "Thanos", "Cheetah", "Zoom", "Rene" };
string[] weapon = { "sword", "gun", "laser", "hammer", "shield", "banana", "logo", "plastic spoon"};

//Hero block
string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
int heroHP = getCharacterHP(hero);
int heroStrikeStrength = heroHP;
Console.WriteLine($"Today {hero} ({heroHP} HP) with {heroWeapon} saves the day!");

//Villain block
string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
int villainHP = getCharacterHP(villain);
int villainStrikeStrength = villainHP;
Console.WriteLine($"But {villain} ({villainHP} HP) with {villainWeapon} is up to no good!");

while (heroHP > 0 && villainHP > 0)
{
    heroHP -= Hit(villain, heroStrikeStrength);
    villainHP -= Hit(hero, villainStrikeStrength);
}

if (heroHP > 0)
{
    Console.WriteLine($"{hero} wins!");
}
else if (villainHP > 0)
{
    Console.WriteLine($"{villain} wins!");
}
else
{
    Console.WriteLine("Draw!");
}

static string GetRandomValueFromArray(string[] array)
{
    Random rnd = new Random();
    int index = rnd.Next(0, array.Length);
    return array[index];
}

static int getCharacterHP(string characterName)
{
    if (characterName.Length < 10)
    {
        return 10;   
    }
    else
    {
        return characterName.Length;
    }
}

static int Hit(string characterName, int characterHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);

    if(strike == 0)
    {
        Console.WriteLine($"{characterName} missed the target!");
    }
    else if (strike == characterHP -1)
    {
        Console.WriteLine($"{characterName} landed a critical hit for {strike} damage!");
    }
    else
    {
        Console.WriteLine($"{characterName} hit for {strike} damage!");
    }
    return strike;
}