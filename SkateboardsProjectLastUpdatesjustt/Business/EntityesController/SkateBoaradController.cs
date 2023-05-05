using SkateboardsProject.Model;
using SkateboardsProject.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Business.EntityesController
{
    public class SkateBoaradController
    {
        private SkateboardsContext Context = new SkateboardsContext();

        public void Add(Skateboard skateboard)
        {
            using (Context = new SkateboardsContext())
            {
                Context.Skateboards.Add(skateboard);
                Context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (Context = new SkateboardsContext())
            {
                var skateboard = Context.Skateboards.Find(id);
                if (skateboard != null)
                {
                    Context.Skateboards.Remove(skateboard);
                    Context.SaveChanges();
                }
            }
        }

        public Skateboard Get(int id)
        {
            using (Context = new SkateboardsContext())
            {
                return Context.Skateboards.Find(id);
            }
        }

        public List<Skateboard> GetAll()
        {
            using (Context = new SkateboardsContext())
            {
                return Context.Skateboards.ToList();
            }
        }

        public void Update(Skateboard skateboard)
        {
            using (Context = new SkateboardsContext())
            {
                var item = Context.Skateboards.Find(skateboard.Id);
                if (item != null)
                {
                    Context.Entry(item).CurrentValues.SetValues(skateboard);
                    Context.SaveChanges();
                }
            }
        }
    }
}
