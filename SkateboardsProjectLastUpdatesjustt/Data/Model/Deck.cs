using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Data.Model
{
    class Deck
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Brand))]
        public ICollection<Brand> Brands { get; set; }
        public Brand BrandId;
        public string Wood_type { get; set; }
        public string Deck_shape { get; set; }
        public string Deck_concave { get; set; }
    }
}
