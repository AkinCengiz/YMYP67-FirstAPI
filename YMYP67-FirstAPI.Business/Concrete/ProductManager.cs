using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP67_FirstAPI.Business.Abstract;
using YMYP67_FirstAPI.DataAccess.Abstract;
using YMYP67_FirstAPI.DataAccess.Concrete.EntityFramework;
using YMYP67_FirstAPI.Entities.Concrete;

namespace YMYP67_FirstAPI.Business.Concrete;
public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(EfProductDal productDal)
    {
        _productDal = productDal;
    }

    public void Insert(Product entity)
    {
        _productDal.Add(entity);
    }

    public void Modify(Product entity)
    {
        _productDal.Update(entity);
    }

    public void Remove(Product entity)
    {
        _productDal.Delete(entity);
    }

    public Product GetById(int id)
    {
        return _productDal.Get(p => p.Id == id);
    }

    public List<Product> GetList()
    {
        return _productDal.GetAll();
    }

    public List<Product> GetProductsByCategory(int categoryId)
    {
        return _productDal.GetAll(p => p.CategoryID == categoryId);
    }

    public List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
    {
        return _productDal.GetAll(p => p.Price >= minPrice && p.Price <= maxPrice);
    }

    public List<Product> GetProductsInStock()
    {
        return _productDal.GetAll(p => p.Stock > 0);
    }

    public List<Product> GetProductsOutOfStock()
    {
        return _productDal.GetAll(p => p.Stock == 0);
    }
}
