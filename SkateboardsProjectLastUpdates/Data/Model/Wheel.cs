using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Data.Model
{
    class Wheel
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Brand))]
        public ICollection<Brand> Brands { get; set; }
        public Brand BrandId;

        public decimal Wheels_size { get; set; }
        public int Hardness { get; set; }
        public string Wheels_shape { get; set; }

    }
}
