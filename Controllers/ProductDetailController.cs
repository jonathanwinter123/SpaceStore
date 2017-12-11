namespace SpaceStorium.Controllers
{
    using System.Web.Mvc;

    public class ProductDetailController : Controller
    {
        // GET: ProductDetail
        public ActionResult ProductDetail(int id)
        {
            ProductFactory productFactory = new ProductFactory(@"\App_Data\data.json");
            return this.View(productFactory.GetSingleProduct(id));
        }
    }
}