﻿String name = "Player 1";
int score = 0;


score += AskQuestion("Vilken är den farligaste björnen i världen?", "A) Isbjörn B) BrunBjörn C) GrizzlyBjörn", "C");
Console.WriteLine($"DU HAR {score} POÄNG!!! ");
score += AskQuestion("Vilken är den farligaste björnen i världen?", "A) Isbjörn B) BrunBjörn C) GrizzlyBjörn", "C");


Console.ReadLine();


static int AskQuestion(string question, string answers, string correct)
{

    Console.WriteLine(question);

    Console.WriteLine("\n");

    Console.WriteLine(answers);
    string answer = Console.ReadLine();

    if (answer.ToUpper() == correct)
    {
        Console.Write("RÄTT!! ");
        return 100;
    }
    else
    {
        Console.WriteLine("Fel Nästa fråga.");
        Console.WriteLine("\n");
        return 0;
    }
}