using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SerieManager : ISerieService
    {
        ISerie _serie;

        public SerieManager(ISerie serie)
        {
            _serie = serie;
        }

        public void SerieAdd(Serie serie)
        {
            _serie.Add(serie);
        }

        public void SerieRemove(Serie serie)
        {
            _serie.Delete(serie);
        }

        public void SerieUpdate(Serie serie)
        {
            _serie.Update(serie);
        }

        public Serie GetById(int id)
        {
            return _serie.GetById(id);
        }

        public List<Serie> ListAll()
        {
            return _serie.ListAll();
        }
    }
}
