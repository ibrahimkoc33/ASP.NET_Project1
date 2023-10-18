using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCategoryRepository:GenericRepository<Category>,ICategory
    {
        //Bu classların oluşturulma sebebi projemizi başka bir ORM aracına (Dapper gibi) taşımak istediğimizde kolaylık sağlamaktır
    }
}
