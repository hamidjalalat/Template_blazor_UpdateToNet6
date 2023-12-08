using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data
{
    public class ProductRepository : Repository<Models.Product>, IProductRepository
    {
        internal ProductRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }

    }
}
