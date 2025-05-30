using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP67_FirstAPI.Business.Abstract;
using YMYP67_FirstAPI.DataAccess.Abstract;
using YMYP67_FirstAPI.DataAccess.Concrete.AdoNet;
using YMYP67_FirstAPI.DataAccess.Concrete.EntityFramework;
using YMYP67_FirstAPI.DataAccess.Concrete.NHibernate;
using YMYP67_FirstAPI.Entities.Concrete;

namespace YMYP67_FirstAPI.Business.Concrete;
public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(EfCategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public Category GetById(int id)
    {
        return _categoryDal.Get(c => c.Id == id);
    }

    public List<Category> GetList()
    {
        return _categoryDal.GetAll();
    }

    public void Insert(Category entity)
    {
        _categoryDal.Add(entity);
    }

    public void Modify(Category entity)
    {
        _categoryDal.Update(entity);
    }

    public void Remove(Category entity)
    {
        _categoryDal.Delete(entity);
    }
}
