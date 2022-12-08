
using Sklep;


var kasa = new Kasa();
kasa.CreateProduct();
var menu = new Menu();

// The 'Wybrane' class is completely unnecessary.
// After all, the shopping cart (paragon) contains the same products as in the store.
// One 'Product' class is enough!!!
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
        if (menu.answer == "P")
        {

                // We must have two values: cena_laczna (this is a sum of all values of cena_brutto of products in paragon)
                // and total_vat (this is a sum of all values of VAT of products in paragon)
                // So we have to options to choose:
                // 1 option (using loop)
                decimal cena_laczna = 0;
                decimal total_vat = 0;
                foreach (var p in wybrane)
                {
                    cena_laczna += p.Cena_brutto;
                    total_vat += p.VAT;
                }
                
                // 2 option (using 'Sum' method)
                cena_laczna = wybrane.Sum(w => w.Cena_brutto);
                total_vat = wybrane.Sum(w => w.VAT);
                
                // Please choose one of those options (whatever you want)

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

            // new Wybrane().Nazwa = p.Nazwa;
            // new Wybrane().Podatek = p.Cena_netto * 0.23m;
            // new Wybrane().Cena_brutto = Math.Round(p.Cena_netto + new Wybrane().Podatek, 2);
            // Console.WriteLine(p.Nazwa);
            // Console.WriteLine("CENA ŁĄCZNA: " + new Wybrane().Cena_brutto + " zł");
            // wybrane.Add(new Wybrane());
            // menu.Zakup();


        }
    }
}

