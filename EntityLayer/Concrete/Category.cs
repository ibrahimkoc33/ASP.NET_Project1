using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category:BaseEntity<int>
    {

        public string Name { get; set; }

        public string color { get; set; }

        public List<Movie> Movies { get; set; }

    }
}
