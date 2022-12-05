
using Sklep;


var kasa = new Kasa();
kasa.CreateProduct();
var menu = new Menu();
var wybrane = new List<Wybrane>();
var products = kasa.AllProducts;
menu.Start();

while (true)
{
    if (menu.IsCorrect(menu.answer!))
    {
        Console.Clear();
        menu.Start();
    }
    if (!menu.IsCorrect(menu.answer!) && menu.answer == "1")
    {
        Console.Clear();
        kasa.DisplayProducts();
        menu.Start();
    }

    if (!menu.IsCorrect(menu.answer!) && menu.answer == "2")
    {
        Console.Clear();
        menu.Zakup();
        if (menu.answer == "P")
        {
            foreach (var w in wybrane)
            {

            }
        }
        else if (menu.answer == "p")
        {
            System.Console.WriteLine(wybrane);
            break;
        }

    }

    var AllProducts = kasa.AllProducts!;

    foreach (var p in AllProducts)
    {
        if (menu.answer == p.Id)
        {

            new Wybrane().Nazwa = p.Nazwa;
            new Wybrane().Podatek = p.Cena_netto * 0.23m;
            new Wybrane().Cena_brutto = Math.Round(p.Cena_netto + new Wybrane().Podatek, 2);
            Console.WriteLine(p.Nazwa);
            Console.WriteLine("CENA ŁĄCZNA: " + new Wybrane().Cena_brutto + " zł");
            wybrane.Add(new Wybrane());
            menu.Zakup();


        }
    }
}

