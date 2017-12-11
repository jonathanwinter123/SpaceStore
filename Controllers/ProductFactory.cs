namespace SpaceStorium.Controllers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Newtonsoft.Json;

    using SpaceStorium.Models;

    public class ProductFactory
    {
        private readonly string dataPath;

        public ProductFactory(string dataPath)
        {
            this.dataPath = dataPath;
        }

        public List<Product> GetAllProducts()
        {
            string projectPath = System.AppDomain.CurrentDomain.BaseDirectory;
            using( StreamReader streamReader = new StreamReader(projectPath + this.dataPath) )
            {
                string json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Product>>(json);
            }
        }

        public Product GetSingleProduct(int id)
        {
            string projectPath = System.AppDomain.CurrentDomain.BaseDirectory;
            using( StreamReader streamReader = new StreamReader(projectPath + this.dataPath) )
            {
                string json = streamReader.ReadToEnd();
                List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(json);
                return productList.Single(p => p.Id == id);
            }
        }
    }
}