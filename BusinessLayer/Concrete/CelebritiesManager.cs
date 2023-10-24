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
	public class CelebritiesManager : ICelebritiesService
	{
		ICelebrities _celebrities;

		public CelebritiesManager(ICelebrities celebrities)
		{
			_celebrities = celebrities;
		}

		public void CelebritiesAdd(Celebrities celebrities)
		{
			_celebrities.Add(celebrities);
		}

		public void CelebritiesRemove(Celebrities celebrities)
		{
			_celebrities.Delete(celebrities);
		}

		public void CelebritiesUpdate(Celebrities celebrities)
		{
			_celebrities.Update(celebrities);
		}

		public Celebrities GetById(int id)
		{
			return _celebrities.GetById(id);
		}

		public List<Celebrities> ListAll()
		{
			return _celebrities.ListAll();
		}


		public List<Celebrities> GetCelebritiesById(int id)
		{
			return _celebrities.ListAll(x => x.Id == id);
		}
	}
}
