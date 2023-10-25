using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class User:BaseEntity<int>
	{
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
