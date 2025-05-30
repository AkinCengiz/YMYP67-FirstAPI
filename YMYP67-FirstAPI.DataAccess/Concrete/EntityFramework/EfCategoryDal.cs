using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YMYP67_FirstAPI.DataAccess.Abstract;
using YMYP67_FirstAPI.Entities.Concrete;

namespace YMYP67_FirstAPI.DataAccess.Concrete.EntityFramework;
public class EfCategoryDal : EfGenericRepository<Category>, ICategoryDal
{
    public EfCategoryDal(FirstApiContext context) : base(context)
    {
        
    }
}
