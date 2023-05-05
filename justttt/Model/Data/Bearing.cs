using SkateboardsProject.Model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Data.Model
{
   public class Bearing
    {
        public int Id { get; set; }
        public ICollection<Skateboard> Skateboards { get; set; }
        public string Name { get; set; }
        public int Abec_ratiang { get; set; }
        public string Bearing_material { get; set; }
    }
}
