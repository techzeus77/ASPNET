using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;
using Dapper;

namespace Testing
{
     public interface IProductRepository
    {
        public IEnumerable<product> GetAllProducts();

        public product GetProduct(int id);

        public void UpdateProduct(product product);




    }




}
