﻿using DataAccess.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataRepository
    {
        private readonly Context Context;

        public DataRepository(Context context) 
        {
            Context = context;
        }

        public async Task<IList<Product>> GetAllProducts()
        {
            return await Context
                .Get<Product>()
                .OrderBy(x => x.ID)
                .ToListAsync();
        }

        public async Task<Product> GetProductForDisplay(int productId)
        {
            return await Context
                .Get<Product>()
                .SingleAsync(x => x.ID == productId);
        }

        public async Task<IList<ProductAvailability>> GetProductAvailabilitiesByProductId(int productId)
        {
            return await Context
                .Get<ProductAvailability>()
                .Where(x => x.ProductID == productId)
                .OrderBy(x => x.Size)
                .ToListAsync();
        }
    }
}
