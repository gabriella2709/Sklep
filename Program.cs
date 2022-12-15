using Sklep;
using System.Data;

var kasa = new Kasa();

var menu = new Menu();
var basket = new List<Product>();



var answer = menu.Start();
if (menu.IsCorrect(answer))
{
    if (answer == "1")
        kasa.DisplayProducts();
    else if (answer == "3")
        return;
    else
    {
        Product product = new Product();
        while(product != null)
        {        
            Console.WriteLine("PODAJ KOD PRODUKTU");
            var barcode = Console.ReadLine();
            if (barcode == "P" || barcode == "p")
                break;

            product = kasa.AllProducts.FirstOrDefault(x => x.Id == barcode);
            if (product == null)
            {
                Console.WriteLine("NIEPRAWIDŁOWY KOD PRODUKTU");
                return;
            }    
            else
            {
                Console.Clear();
                Console.WriteLine(product.Nazwa + "||" +  Math.Round(product.Cena_netto, 2) + " zł");
                basket.Add(product);
            }
        }

        Console.Clear();
        Console.WriteLine("___________________________________________________");
        Console.WriteLine("PARAGON");
        Console.WriteLine("DATA ZAKUPU: " + DateTime.Now.ToString("F"));
        Console.WriteLine("___________________________________________________");
        Console.WriteLine();
        foreach (var p in basket)
        {
            Console.WriteLine(p.Nazwa + "||" + Math.Round(p.Cena_netto, 2) + " zł");
        }

        var total = Math.Round(basket.Sum(x => x.Cena_brutto), 2);
        var vat = Math.Round(basket.Sum(x => x.VAT), 2);
        System.Console.WriteLine("___________________________________________________");
        System.Console.WriteLine("DO ZAPŁATY: " + total + " zł");
        System.Console.WriteLine("W TYM VAT: " + vat + " zł");
        System.Console.WriteLine("___________________________________________________");

    }
}
else
{
    Console.WriteLine("Nieprawidłowy klawisz");
}
