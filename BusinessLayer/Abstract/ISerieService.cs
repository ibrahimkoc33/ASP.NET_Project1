using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISerieService
    {
        void SerieAdd(Serie serie);
        void SerieRemove(Serie serie);
        void SerieUpdate(Serie serie);
        List<Serie> ListAll();

        Serie GetById(int id);

		List<Serie> GetSerieByCategory();
	}
}
