using SkateboardsProject.Data.Model;
using SkateboardsProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Business
{
  public  class BrandController
    {
        private SkateboardsContext Context = new SkateboardsContext();

        /// <summary>
        /// Get all producst from the database
        /// </summary>
        public List<Brand> GetAll()
        {
            using (Context = new SkateboardsContext())
            {
                return Context.Brands.ToList();
            }
        }

        /// <summary>
        /// Get single product from the database by Id
        /// </summary>
        public Brand Get(int id)
        {
            using (Context = new SkateboardsContext())
            {
                return Context.Brands.Find(id);
            }
        }

        /// <summary>
        /// Add a product to the database
        /// </summary>
        public void Add(Brand brand)
        {
            using (Context = new SkateboardsContext())
            {
                Context.Brands.Add(brand);
                Context.SaveChanges();
            }
        }

        /// <summary>
        /// Update a single product in the database by Id.
        /// </summary>
        public void Update(Brand brand)
        {
            using (Context = new SkateboardsContext())
            {
                var item = Context.Brands.Find(brand.Id);
                if (item != null)
                {
                    Context.Entry(item).CurrentValues.SetValues(brand);
                    Context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Deleate a product from the database by Id
        /// </summary>
        public void Delete(int id)
        {
            using (Context = new SkateboardsContext())
            {
                var brand = Context.Brands.Find(id);
                if (brand != null)
                {
                    Context.Brands.Remove(brand);
                    Context.SaveChanges();
                }
            }
        }

    }
}
