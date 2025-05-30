using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YMYP67_FirstAPI.DataAccess.Abstract;
using YMYP67_FirstAPI.Entities.Concrete;

namespace YMYP67_FirstAPI.DataAccess.Concrete.AdoNet;
public class AdoCategoryDal : ICategoryDal
{
    public void Add(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Category entity)
    {
        throw new NotImplementedException();
    }

    public Category Get(Expression<Func<Category, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Category> GetAll(Expression<Func<Category, bool>>? filter = null)
    {
        throw new NotImplementedException();
    }

    public void Update(Category entity)
    {
        throw new NotImplementedException();
    }
}
