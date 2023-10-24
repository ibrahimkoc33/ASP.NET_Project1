using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICelebritiesService
	{
		void CelebritiesAdd(Celebrities celebrities);
		void CelebritiesRemove(Celebrities celebrities);
		void CelebritiesUpdate(Celebrities celebrities);
		List<Celebrities> ListAll();

		Celebrities GetById(int id);
	}
}
