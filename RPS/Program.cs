// See https://aka.ms/new-console-template for more information
string firstAllowedSign = "fire";
string secondAllowedSign = "water";
string thirdAllowedSign = "grass";

string[] allowedSigns = ["fire", "water", "grass"];
int firstPlayerPoints = 0;
int secondPlayerPoints = 0;

while (true)
{
    // Console.WriteLine("Graczu 1, podaj znak (rock/paper/scissors)");
    // Console.WriteLine("Graczu 1, podaj znak (" + firstAllowedSign + "/" + secondAllowedSign + "/" + thirdAllowedSign + ")");
    // Console.WriteLine($"Graczu 1, podaj znak ({firstAllowedSign}/{secondAllowedSign}/{thirdAllowedSign})");
    // Console.WriteLine($"Graczu 1, podaj znak ({allowedSigns[0]}/{allowedSigns[1]}/{allowedSigns[2]})");
    Console.WriteLine($"Graczu 1, podaj znak ({string.Join("/", allowedSigns)})");
    // typ nazwa;
    // typ nazwa = wartość;
    // string firstSign = (Console.ReadLine() ?? string.Empty).ToLower();
    string firstSign = Console.ReadLine()?.ToLower() ?? string.Empty;
    // firstSign = firstSign.ToLower();

    // liczby całkowite - typ int

    // while (firstSign != firstAllowedSign && firstSign != secondAllowedSign && firstSign != thirdAllowedSign)
    // while (firstSign != allowedSigns[0] && firstSign != allowedSigns[1] && firstSign != allowedSigns[2])
    while (!allowedSigns.Contains(firstSign))
    {
        Console.WriteLine("Niepoprawny znak!");
        // Console.WriteLine($"Wpisz POPRAWNY znak, graczu 1 ({firstAllowedSign}/{secondAllowedSign}/{thirdAllowedSign})");
        Console.WriteLine($"Wpisz POPRAWNY znak, graczu 1 ({string.Join("/", allowedSigns)})");
        firstSign = Console.ReadLine()?.ToLower() ?? string.Empty;
    }


    // Console.WriteLine($"Graczu 2, podaj znak ({firstAllowedSign}/{secondAllowedSign}/{thirdAllowedSign})");
    Console.WriteLine($"Graczu 2, podaj znak ({string.Join("/", allowedSigns)})");
    string secondSign = Console.ReadLine()?.ToLower() ?? string.Empty;
    Console.WriteLine(secondSign);

    // while (secondSign != firstAllowedSign && secondSign != secondAllowedSign && secondSign != thirdAllowedSign)
    while (!allowedSigns.Contains(secondSign))
    {
        Console.WriteLine("Niepoprawny znak!");
        // Console.WriteLine($"Wpisz POPRAWNY znak, graczu 2 ({firstAllowedSign}/{secondAllowedSign}/{thirdAllowedSign})");
        Console.WriteLine($"Wpisz POPRAWNY znak, graczu 2 ({string.Join("/", allowedSigns)})");
        secondSign = Console.ReadLine()?.ToLower() ?? string.Empty;
    }

    if (firstSign == secondSign)
    {
        Console.WriteLine("Remis!");
    }
    else if ((firstSign == firstAllowedSign && secondSign == thirdAllowedSign) || (firstSign == secondAllowedSign && secondSign == firstAllowedSign) || (firstSign == thirdAllowedSign && secondSign == secondAllowedSign))
    {
        Console.WriteLine("Gracz 1 MISZCZ!");
        // firstPlayerPoints = firstPlayerPoints + 1;
        firstPlayerPoints += 1;
    }
    else
    {
        Console.WriteLine("Gracz 2 MISZCZ");
        // secondPlayerPoints = secondPlayerPoints + 1;
        secondPlayerPoints += 1;
    }

    Console.WriteLine($"Punkty gracza 1: {firstPlayerPoints}");
    Console.WriteLine($"Punkty gracza 2: {secondPlayerPoints}");

    Console.WriteLine("Czy koniec na dziś?");
    if (Console.ReadLine() == "tak")
    {
        break;
    }
}

Console.WriteLine("Dziękuję za grę");