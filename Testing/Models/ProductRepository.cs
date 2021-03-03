
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<product> GetAllProducts()
        {
            return _conn.Query<product>("SELECT * FROM PRODUCTS;");
        }




    }
}
