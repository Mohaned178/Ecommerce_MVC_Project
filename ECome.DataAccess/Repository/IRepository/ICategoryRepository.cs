using ECom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECom.DataAccess.Repository;
using System.Threading.Tasks;

namespace ECom.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
