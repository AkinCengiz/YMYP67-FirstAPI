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
public class PersonManager : IPersonService
{
    private readonly IPersonDal _personDal;

    public PersonManager(EfPersonDal personDal)
    {
        _personDal = personDal;
    }

    public Person GetById(int id)
    {
        return _personDal.Get(p => p.Id == id);
    }

    public List<Person> GetList()
    {
        return _personDal.GetAll();
    }

    public IQueryable<Person> GetAllQueryable()
    {
        throw new NotImplementedException();
    }

    public void Insert(Person entity)
    {
        _personDal.Add(entity);
    }

    public void Modify(Person entity)
    {
        _personDal.Update(entity);
    }

    public void Remove(Person entity)
    {
        _personDal.Delete(entity);
    }
}
