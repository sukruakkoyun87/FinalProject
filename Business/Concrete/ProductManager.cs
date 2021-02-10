using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
        private IResult _result;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {
                return new ErrorResult("Ürün ismi en az 2 karakter olmalıdır");
            }
            _productDal.Add(product);
            return new Result(true,"Ürün eklendi");
        }


        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int Id)
        {
            return _productDal.GetAll(x=>x.CategoryId==Id);
        }

        public List<Product> GetByUnitPirce(decimal min, decimal max)
        {
            return _productDal.GetAll(x => x.UnitPrice >= min && x.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
