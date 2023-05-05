using SkateboardsProject.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Data.Model
{
   public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public string Country { get; set; }

        public ICollection<Skateboard> Skateboards { get; set; }
    }
}
