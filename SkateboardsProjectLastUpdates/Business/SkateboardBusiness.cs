using SkateboardsProject.Business.EntityesController;
using SkateboardsProject.Data.Model;
using SkateboardsProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Business
{
    public class SKBusiness
    {
        BearingController bearingController = new BearingController();
        BrandController brandController = new BrandController();
        DeckController deckController = new DeckController();
        WheelsController wheelsController = new WheelsController();
        SkateBoaradController skateBoaradController = new SkateBoaradController();
    }
}
