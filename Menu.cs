﻿namespace Sklep;

public class Menu
{
    public string answer { get; set; }
    public void Start()
    {
        Console.WriteLine("WYBIERZ OPCJĘ:");
        Console.WriteLine("1 => LISTA WSZYSTKICH PRODUKTÓW");
        Console.WriteLine("2 => ZAKUPY");
        Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
        Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
        answer = Console.ReadLine();
    }

    public bool IsCorrect(string answer)
    {
        if (int.TryParse(answer, out int x) && x > 0 && x < 3)
            return false;
        
        return true;
        }
}