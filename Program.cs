
using Sklep;

var kasa = new Kasa();
kasa.CreateProduct();
var menu = new Menu();
menu.Start();
while (true)
{
    if (menu.IsCorrect(menu.answer))
    {
        Console.Clear();
        menu.Start();
    }
    if(!menu.IsCorrect(menu.answer) && menu.answer == "1")
    {
        Console.Clear();
        kasa.DisplayProducts();
        menu.Start();
    }

    if (!menu.IsCorrect(menu.answer) && menu.answer == "2")
    {
        Console.Clear();
        Console.WriteLine("Zakupy");
        menu.Start();
    }
    
    if(menu.IsCorrect(menu.answer) && menu.answer == "3")
        break;
}

