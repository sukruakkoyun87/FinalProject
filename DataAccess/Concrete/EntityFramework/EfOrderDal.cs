using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFrameworkF;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal:EfEntityRespositoryBase<Order,NorthwindContext>,IOrderDal
    {
    }
}
