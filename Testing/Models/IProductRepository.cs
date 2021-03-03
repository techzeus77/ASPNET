using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Testing.Models;

namespace Testing
{
     public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return _Conn.Query<product>("SELECT * FROM PRODUCTS;");
        }
    }
}
