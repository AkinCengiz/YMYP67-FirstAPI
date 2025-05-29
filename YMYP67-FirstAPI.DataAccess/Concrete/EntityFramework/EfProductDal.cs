using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YMYP67_FirstAPI.Entities.Concrete;

namespace YMYP67_FirstAPI.DataAccess.Concrete.EntityFramework;
public class EfProductDal
{
    private FirstApiContext _context;
    private DbSet<Product> _dbSet;

    public EfProductDal(FirstApiContext context)
    {
        _context = context;
        _dbSet = _context.Set<Product>();
    }
    public void Delete(Product product)
    {
        _dbSet.Remove(product);
        _context.SaveChanges();
    }
}
