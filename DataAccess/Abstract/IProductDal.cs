﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
        //Dal/Dao: Data Access katmanının nesnesidir.
    {
        List<ProductDetailDto> GetProductDetails();  

    }
}
//Code Refactoring
