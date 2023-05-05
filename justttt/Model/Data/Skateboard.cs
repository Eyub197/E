using SkateboardsProject.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Model.Data
{
    public class Skateboard
    {
        public int Id { get; set; }
        public decimal Price { get; set; }

        [ForeignKey(nameof(Deck))]
      
        public Deck DeckId { get; set; }

        [ForeignKey(nameof(Wheel))]
        
        public Wheel WheelId { get; set; }

        public string Hardware { get; set; }

        [ForeignKey(nameof(Bearing))]
     
        public Bearing BearingId;

        [ForeignKey(nameof(Brand))]

        public Brand BrandId { get; set;}

        public DateTime Date_of_production { get; set; }

    }
}
