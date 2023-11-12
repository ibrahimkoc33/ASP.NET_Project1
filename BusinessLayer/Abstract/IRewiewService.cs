using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRewiewService
    {
        void RewiewAdd(Rewiew rewiew);
        //void CategoryRemove(Category category);
        //void CategoryUpdate(Category category);
        List<Rewiew> ListAll(int id);
        List<Rewiew> ListAll();


        Rewiew GetById(int id);
    }
}
