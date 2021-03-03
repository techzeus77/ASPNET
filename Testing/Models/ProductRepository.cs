
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class ProductRepository: IProductRepository
    {
        private readonly IDbConnection _Conn;

        public ProductRepository(IDbConnection Conn)
        {
            _Conn = Conn;
        }

        public IEnumerable<Product> GetAllProduts()
        {
            return _Conn.Query<product>("SELECT * FROM PRODUCTS;");
        }




    }
}
