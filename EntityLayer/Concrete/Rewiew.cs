using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Rewiew:BaseEntity<int>
    {

        public string Title { get; set; }
        public string Description { get; set; }

        public string Writer { get; set; }

        public int Star { get; set; }

        public DateOnly Date { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
