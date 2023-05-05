﻿using SkateboardsProject.Model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Data.Model
{
    public class Deck
    {
        public int Id { get; set; }

        public ICollection<Skateboard> Skateboards { get; set; }
        public string Wood_type { get; set; }
        public string Deck_shape { get; set; }
        public string Deck_concave { get; set; }
        
    }
}
