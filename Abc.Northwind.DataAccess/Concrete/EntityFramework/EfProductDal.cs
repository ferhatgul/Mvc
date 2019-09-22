﻿using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Abc.Core.EntityFramework;
using Abc.Northwind.DataAccess.Concrete.EntityFramework.Context;

namespace Abc.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
    {

    }
}
