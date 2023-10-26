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
    public class RewiewManager : IRewiewService
    {
        IRewiew _rewiew;

        public RewiewManager(IRewiew rewiew)
        {
            _rewiew = rewiew;
        }

        public List<Rewiew> ListAll(int id)
        {
            return _rewiew.ListAll(x=>x.MovieId == id);
        }

        public void RewiewAdd(Rewiew rewiew)
        {
            throw new NotImplementedException();
        }
    }
}
