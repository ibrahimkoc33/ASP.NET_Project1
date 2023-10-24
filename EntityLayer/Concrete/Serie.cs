using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Serie:BaseEntity<int>
    {

        public string Name { get; set; }

        public string Genre { get; set; }

        public string Director { get; set; } //list olabilir

        public string Scenarist { get; set; }

        public string Cast { get; set; } // liste olucak düzelt

        public string Image { get; set; }

        public float Star { get; set; }

        public DateOnly Date { get; set; }
        public int Season { get; set; }

        public int? RewiewId { get; set; }
        public Rewiew SerieRewiew { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
