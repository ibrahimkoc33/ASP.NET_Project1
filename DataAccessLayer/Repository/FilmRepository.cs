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
    public class FilmRepository : IFilm
    {
        public void Add(Film film)
        {
            using var c=new Context();
            c.Add(film);
            c.SaveChanges();
        }

        public void Delete(Film film)
        {
            using var c = new Context();
            c.Remove(film);
            c.SaveChanges();

        }
        public void Update(Film film)
        {
            using var c = new Context();
            c.Update(film);
            c.SaveChanges();

        }
        public Film GetById(int id)
        {
            using var c = new Context();
            return c.Films.Find(id);
        }

        public List<Film> ListAll()
        {
            using var c = new Context();
            return c.Films.ToList();
        }


    }
}
