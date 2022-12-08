namespace Sklep;

public class Product
{
	public string? Id { get; set; }
	public string? Nazwa { get; set; }
	public decimal Cena_netto { get; set; }

	
	// We add the 'VAT' property, which we can calculate automatically (23 % of cena netto)
	public decimal VAT
	{
		get { return Cena_netto * 0.23m; }
	}
	
	// We add the 'Cena_brutto' property, which we can calculate automatically (cena netto plus VAT)
	public decimal Cena_brutto
	{
		get { return Cena_netto * 1.23m; }
	}
}