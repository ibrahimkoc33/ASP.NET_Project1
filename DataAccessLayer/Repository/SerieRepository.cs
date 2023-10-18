using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class SerieRepository : ISerie
    {
        public void Add(Serie Serie)
        {
            using var c = new Context();
            c.Add(Serie);
            c.SaveChanges();
        }

        public void Delete(Serie Serie)
        {
            using var c = new Context();
            c.Remove(Serie);
            c.SaveChanges();
        }
        public void Update(Serie Serie)
        {
            using var c = new Context();
            c.Remove(Serie);
            c.SaveChanges();
        }
        public Serie GetById(int id)
        {
            using var c = new Context();
            return c.Series.Find(id);
        }

        public List<Serie> ListAll()
        {
            using var c = new Context();
            return c.Series.ToList();
        }

        
    }
}
