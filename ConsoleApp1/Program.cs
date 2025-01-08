string[] defaultTexts = ["kotek", "Solid Snake", "SWPS"];
Console.WriteLine("Podaj słowo do zgadywania:");
string fullText = Console.ReadLine() ?? string.Empty;

if (string.IsNullOrWhiteSpace(fullText))
{
    Console.WriteLine("Losuję tekst  do odgadnięcia");
    
    int textIndex = Random.Shared.Next(defaultTexts.Length);
    fullText = defaultTexts[textIndex];
}

Console.WriteLine("Ile jest szans na zgadnięcie?");
if (!int.TryParse(Console.ReadLine(), out int lives))
{
    lives = 3;
    Console.WriteLine($"Nieporawna wartość. Ustawiam liczbę szans na {lives}");
}

// Poniższa linijka wywali grę, jeśli uruchomi się ją w Debug Console, dlatego zakomentowałem
// Console.Clear();
string[] knownLetters = new string[fullText.Length];
Array.Fill(knownLetters, "-");

int index = Random.Shared.Next(fullText.Length);
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

    if (fullText.ToLower().Contains(letter.ToLower()))
    {
        for (int i = 0; i < knownText.Length; i++)
        {
            if (knownText[i] == '-')
            {
                if (fullText[i].ToString().ToLower() == letter.ToLower())
                {
                    Console.WriteLine("Ta litera znajduje się w słowie!");
                    knownLetters[i] = fullText[i].ToString();
                }
            }
        }

        knownText = string.Join(string.Empty, knownLetters);
    }
    else
    {
        Console.WriteLine("Litera, której szukasz znajduje się w innym zamku");
        lives -= 1;

    } 
}

if (lives > 0)
{
    Console.WriteLine($"Tak! Tekst to {knownText}");
}
else
{
    Console.WriteLine($"Starałeś się, starałeś, a i tak przegrałeś! Poprawny tekst to {fullText}");
}