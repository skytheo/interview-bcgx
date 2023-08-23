using bcgx.Controllers;
using NUnit.Framework;

namespace bcgx{
    public class WatchCatalogControllerTest{
        [Test]
        public void GetPriceOneWatchTest(){
            WatchCatalogController controller = new WatchCatalogController();
            int price = controller.checkout(new []{"001"});
            Assert.AreEqual(price, 100);
        }
    }
}