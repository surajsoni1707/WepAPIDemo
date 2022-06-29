using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepAPIDemo.Model;

namespace WepAPIDemo.Repositories
{
     public interface IProductRepositoy
    {
        IEnumerable<Product> GetAllProducts();
        int AddProduct(Product prod);
        int ModifyProduct(Product prod);
        int DeleteProduct(int id);

    }
}
