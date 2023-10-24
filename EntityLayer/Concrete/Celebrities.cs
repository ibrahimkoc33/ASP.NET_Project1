using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Celebrities: BaseEntity<int>
	{
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public string Job { get; set; }
        public string Image { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Country { get; set; }
        public Movie? Movies { get; set; }
        public Serie? Series { get; set; }
    }
}
