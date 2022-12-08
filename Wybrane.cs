namespace Sklep;



// This class is completely unnecessary.
// After all, the shopping cart contains the same products as in the store.
// One 'Product' class is enough!!!
public class Wybrane
{
    public string? Nazwa { get; set; }
    public decimal Cena_brutto { get; set; }
    public decimal Podatek { get; set; }
}