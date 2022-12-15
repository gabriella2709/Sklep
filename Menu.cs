namespace Sklep;

public class Menu
{
    public string Start()
    {
        Console.WriteLine("WYBIERZ OPCJĘ:");
        Console.WriteLine("1 => LISTA WSZYSTKICH PRODUKTÓW");
        Console.WriteLine("2 => ZAKUPY");
        Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
        Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
        return Console.ReadLine();
    }

    public bool IsCorrect(string answer)
    {
        return answer == "1" || answer == "2" || answer == "3";
    }


}