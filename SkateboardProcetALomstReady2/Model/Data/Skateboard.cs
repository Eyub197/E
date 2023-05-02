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
        public ICollection<Deck> Decks { get; set; }

        public Deck DeckId;

        [ForeignKey(nameof(Wheel))]
        public ICollection<Wheel> Wheels { get; set; }

        public Wheel WheelId;

       public string Hardware { get; set; }

        [ForeignKey(nameof(Bearing))]
        public ICollection<Bearing> Bearings { get; set; }

        public Bearing BearingId;

        [ForeignKey(nameof(Brand))]
        public ICollection<Brand> Brands { get; set; }

        public Brand BrandId;

        public DateTime Date_of_production { get; set; }

    }
}
