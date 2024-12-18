string firstAllowedSign = "fire";
string secondAllowedSign = "water";
string thirdAllowedSign = "grass";

string[] allowedSigns = ["fire", "water", "grass"];
int firstPlayerPoints = 0;
int secondPlayerPoints = 0;

while (true)
{
    // Console.WriteLine($"Graczu 1, podaj znak ({string.Join("/", allowedSigns)})");
    // string firstSign = Console.ReadLine()?.ToLower() ?? string.Empty;

    // while (!allowedSigns.Contains(firstSign))
    // {
    //     Console.WriteLine("Niepoprawny znak!");
    //     Console.WriteLine($"Wpisz POPRAWNY znak, graczu 1 ({string.Join("/", allowedSigns)})");
    //     firstSign = Console.ReadLine()?.ToLower() ?? string.Empty;
    // }


    // Console.WriteLine($"Graczu 2, podaj znak ({string.Join("/", allowedSigns)})");
    // string secondSign = Console.ReadLine()?.ToLower() ?? string.Empty;
    // Console.WriteLine(secondSign);

    // while (!allowedSigns.Contains(secondSign))
    // {
    //     Console.WriteLine("Niepoprawny znak!");
    //     Console.WriteLine($"Wpisz POPRAWNY znak, graczu 2 ({string.Join("/", allowedSigns)})");
    //     secondSign = Console.ReadLine()?.ToLower() ?? string.Empty;
    // }
    string firstSign = GetSign(1);
    string secondSign = GetSign(2);

    if (firstSign == secondSign)
    {
        Console.WriteLine("Remis!");
    }
    else if ((firstSign == firstAllowedSign && secondSign == thirdAllowedSign) || (firstSign == secondAllowedSign && secondSign == firstAllowedSign) || (firstSign == thirdAllowedSign && secondSign == secondAllowedSign))
    {
        Console.WriteLine("Gracz 1 MISZCZ!");
        firstPlayerPoints += 1;
    }
    else
    {
        Console.WriteLine("Gracz 2 MISZCZ");
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


// typ_wartości_zwracanej nazwa_metody(informacje_wejściowe)
string GetSign(int playerNumber)
{
    Console.WriteLine($"Graczu {playerNumber}, podaj znak ({string.Join("/", allowedSigns)})");
    string sign = Console.ReadLine()?.ToLower() ?? string.Empty;

    while (!allowedSigns.Contains(sign))
    {
        Console.WriteLine("Niepoprawny znak!");
        Console.WriteLine($"Wpisz POPRAWNY znak, graczu {playerNumber} ({string.Join("/", allowedSigns)})");
        sign = Console.ReadLine()?.ToLower() ?? string.Empty;
    }

    return sign;
}