using Newtonsoft.Json;


namespace Sklep;

public class Kasa
{
    public List<Product> AllProducts { get; set; }

    public void CreateProduct()
    {
        var path = $"{Directory.GetCurrentDirectory()}\\products.json";
        var json = File.ReadAllText(path);
        AllProducts = JsonConvert.DeserializeObject<List<Product>>(json);

    }

    public void DisplayProducts()
    {
        Console.WriteLine("KOD KRESKOWY | NAZWA");
        foreach (var p in AllProducts)
        {
            Console.WriteLine(p.Id + " | " + p.Nazwa);
        }
    }
    
    public bool IsCorrectCode(string answer)
    {
        var menu = new Menu();
        foreach (var p in AllProducts)
        {
            if (answer == p.Id)
            {
                Console.Clear();
                var wybrane = new Wybrane();
                wybrane.Nazwa = p.Nazwa;
                wybrane.Podatek = p.Cena_netto * 0.23m;
                wybrane.Cena_brutto = Math.Round(p.Cena_netto + wybrane.Podatek, 2);
                Console.WriteLine(p.Nazwa);
                Console.WriteLine("CENA ŁĄCZNA: " + wybrane.Cena_brutto + " zł");
                menu.Zakup();
                
                return true;
            }
            
            
        }
        if (answer.ToLower() == answer.ToLower())
            return true;
        
        return false;
    }
    
}