namespace bcgx;

public class Watch
{
    public string id { get; set; }
    public string name { get; set; }
    public int price { get; set; }
    public string? discount { get; set; }

    public Watch(string id, string name, int price, string? discount = null)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        this.discount = discount;
    }
}

public class WatchCatalog
{
    public static Watch[] catalog { get; set; }
    public WatchCatalog()
    {
        catalog = new Watch[] {
            new Watch("001", "Rolex", 100, "3 for 200"),
            new Watch("002", "Michael Kors", 80, "2 for 120"),
            new Watch("003", "Swatch", 50),
            new Watch("004", "Casio", 30)
        };
    }
}