using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Presentation
{
   public interface IPresentaion<T>
    {
        void ShowMenu();
        void Delete();
        void Find();
        void Update();
        void Add();
        void ListAll();
    }
}
