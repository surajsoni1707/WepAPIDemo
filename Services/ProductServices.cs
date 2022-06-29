using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepAPIDemo.Model;
using WepAPIDemo.Repositories;

namespace WepAPIDemo.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepositoy _iProductRepo;
        // Injecition of Dependancy using constructor
        public ProductServices(IProductRepositoy iProductRepo)
        {
            _iProductRepo = iProductRepo;
        }
        public int AddProduct(Product prod)
        {
            return _iProductRepo.AddProduct(prod);
        }
        public int DeleteProduct(int id)
        {
            return _iProductRepo.DeleteProduct(id);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _iProductRepo.GetAllProducts();
        }
        public int ModifyProduct(Product prod)
        {
            return _iProductRepo.ModifyProduct(prod);
        }

    }
}
