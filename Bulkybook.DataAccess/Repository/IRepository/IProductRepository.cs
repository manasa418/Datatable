﻿using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulkybook.DataAccess.Repository.IRepository
{
    public interface IProductRepository :IRepository<Product>
    {
        void Update(Product obj);//update methods will be inside category specific repository rather than in iRepository interface.
        
         

    }
}
