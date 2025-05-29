using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YMYP67_FirstAPI.Entities.Concrete;

namespace YMYP67_FirstAPI.DataAccess.Concrete.EntityFramework;
public class EfCategoryDal
{
    private FirstApiContext _context;
    private DbSet<Category> _dbSet;

    public EfCategoryDal(FirstApiContext context)
    {
        _context = context;
        _dbSet = _context.Set<Category>();
    }

    public void Add(Category category)
    {
        _dbSet.Add(category);
        _context.SaveChanges();
    }
}
