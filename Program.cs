using Sklep;

var kasa = new Kasa();
kasa.CreateProduct();
var menu = new Menu();
var now = DateTime.Now;
var AllProducts = kasa.AllProducts!;
var wybrane = new List<Product>();
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
    }
    if (!menu.IsCorrect(menu.answer!) && menu.answer == "3")
    {
        break;
    }
    if (menu.answer == "P")
    {
        Console.Clear();
        Console.WriteLine("___________________________________________________");
        Console.WriteLine("PARAGON");
        System.Console.WriteLine("DATA ZAKUPU: " + now.ToString("F"));
        Console.WriteLine("___________________________________________________");

        foreach (var p in wybrane)
        {
            System.Console.WriteLine(p.Nazwa + "||" + p.Cena_netto + " zł");
        }
        decimal cena_laczna = 0;
        decimal total_vat = 0;
        foreach (var p in wybrane)
        {
            cena_laczna += p.Cena_brutto;
            total_vat += p.VAT;
        }
        System.Console.WriteLine("___________________________________________________");
        System.Console.WriteLine("DO ZAPŁATY: " + cena_laczna + " zł");
        System.Console.WriteLine("W TYM VAT: " + total_vat + " zł");
        System.Console.WriteLine("___________________________________________________");
        break;
    }
    else if (menu.answer == "p")
    {
        Console.Clear();
        Console.WriteLine("___________________________________________________");
        Console.WriteLine("PARAGON");
        System.Console.WriteLine("DATA ZAKUPU: " + now.ToString("F"));
        Console.WriteLine("___________________________________________________");

        foreach (var p in wybrane)
        {
            System.Console.WriteLine(p.Nazwa + "||" + p.Cena_netto + " zł");
        }
        decimal cena_laczna = 0;
        decimal total_vat = 0;
        foreach (var p in wybrane)
        {
            cena_laczna += p.Cena_brutto;
            total_vat += p.VAT;
        }
        System.Console.WriteLine("___________________________________________________");
        System.Console.WriteLine("DO ZAPŁATY: " + cena_laczna + " zł");
        System.Console.WriteLine("W TYM VAT: " + total_vat + " zł");
        System.Console.WriteLine("___________________________________________________");
        break;
    }
    foreach (var p in AllProducts)
    {
        if (menu.answer == p.Id)
        {
            Console.Clear();
            var p1 = p;
            System.Console.WriteLine(p.Nazwa);
            Console.WriteLine("CENA ŁĄCZNA: " + Math.Round(p.Cena_brutto + p.VAT, 2) + " zł");
            menu.Zakup();
        }
    }
}







