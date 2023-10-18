using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Repository
{
    public class CategoryRepository : ICategory
    {
        protected readonly Context Context;
        public CategoryRepository(Context context)
        {
            Context = context;
        }
        //IConfiguration Configuration;
        public void Add(Category category)
        {
            /*using var c = new Context(Configuration);
            c.Add(category);
            c.SaveChanges();
            */
            Context.Set<Category>().Add(category);
        }

        public void Delete(Category category)
        {
            Context.Set<Category>().Remove(category);
        }
        public void Update(Category category)
        {
            Context.Set<Category>().Update(category);
        }
        public Category GetById(int id)
        {
            return Context.Set<Category>().Find(id);
        }

        public List<Category> ListAll()
        {
            return Context.Set<Category>().ToList();
            //return c.Categorys.ToList();
        }


    }
}
