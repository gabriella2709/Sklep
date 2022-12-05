using Newtonsoft.Json;
using System.Linq;

namespace Sklep;

public class Kasa
{


    public List<Product>? AllProducts { get; set; }

    public void CreateProduct()
    {
        var path = $"{Directory.GetCurrentDirectory()}\\products.json";
        var json = File.ReadAllText(path);
        AllProducts = JsonConvert.DeserializeObject<List<Product>>(json);

    }


    public void DisplayProducts()
    {
        Console.WriteLine("KOD KRESKOWY | NAZWA");
        foreach (var p in AllProducts!)
        {
            Console.WriteLine(p.Id + " | " + p.Nazwa);
        }
    }



}