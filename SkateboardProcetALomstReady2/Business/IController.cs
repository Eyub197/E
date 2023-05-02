using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Business
{
    interface IController<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        void Get(int id);
        List<T> GetAll();
   
    }
}
