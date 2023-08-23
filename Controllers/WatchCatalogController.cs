using Microsoft.AspNetCore.Mvc;

namespace bcgx.Controllers;

[ApiController]
[Route("[controller]")]
public class WatchCatalogController : ControllerBase
{   
    [HttpPost(Name = "checkout")]
    public int checkout([FromBody] string[] watches){
        int price = 0;
        var res = watches.GroupBy(x=> x);
        foreach(var group in res){
            Watch w = WatchCatalog.catalog.First(x=> x.id == group.Key);
            if(w.discount != null){
                string[] parts = w.discount.Split();
                int num = int.Parse(parts[0]);
                int newPrice = int.Parse(parts[2]);
                int div = group.Count() / num;
                int rem = group.Count() % num;
                price += div * newPrice;
                price += rem *w.price;
            } else {
                price += w.price * group.Count();
            }
        }
        return price;
    }

}
