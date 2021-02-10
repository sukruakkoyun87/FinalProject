using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int Id);
        List<Product> GetByUnitPirce(decimal min,decimal max);
        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productId);
        IResult Add(Product product);

    }
}
