Console.WriteLine("Podaj słowo do zgadywania:");
string fullText = Console.ReadLine();
Console.WriteLine("Ile jest szans na zgadnięcie?");
// int lives = Convert.ToInt32(Console.ReadLine());
// int lives = int.Parse(Console.ReadLine());
// int lives;
// int.TryParse(Console.ReadLine(), out lives);
if (!int.TryParse(Console.ReadLine(), out int lives))
{
    lives = 3;
}

// Poniższa linijka wywali grę, jeśli uruchomi się ją w Debug Console, dlatego zakomentowałem
// Console.Clear();
string[] knownLetters = new string[fullText.Length];
Array.Fill(knownLetters, "-");

// 01234
// kotek
Random rng = new Random();
int index = rng.Next(fullText.Length);
string preguestLetter = fullText[index].ToString();

int start = 0;
while (true)
{
    int i = fullText.IndexOf(preguestLetter, start);
    if (i == -1)
    {
        break;
    }
    
    knownLetters[i] = preguestLetter;
    start = i + 1;
}

string knownText = string.Join(string.Empty, knownLetters);

while (lives > 0 && knownText != fullText)
{
    Console.WriteLine($"Znany tekst: {knownText}");
    Console.WriteLine("Zgadnij literę:");
    string letter = Console.ReadLine();

    if (fullText.Contains(letter))
    {
        for (int i = 0; i < knownText.Length; i++)
        {
            if (knownText[i] == '-')
            {
                if (fullText[i].ToString() == letter)
                {
                    Console.WriteLine("Ta litera znajduje się w słowie!");
                    knownLetters[i] = letter;
                }
            }
        }

        knownText = string.Join(string.Empty, knownLetters);
    }
    else
    {
        Console.WriteLine("Litera, której szukasz znajduje się w innym zamku");
        // lives = lives - 1;
        lives -= 1;
        // lives--;

    }
    
    // if (lives <= 0)
    // {
    //     break;
    // } 
}

if (lives > 0)
{
    Console.WriteLine($"Tak! Tekst to {knownText}");
}
else
{
    Console.WriteLine($"Starałeś się, starałeś, a i tak przegrałeś! Poprawny tekst to {fullText}");
}