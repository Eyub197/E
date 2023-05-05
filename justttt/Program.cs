using SkateboardsProject.Presentation;
using SkateboardsProject.Presentation.Display;
using System;

namespace SkateboardsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Display display = new Display();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :( ");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
            finally
            {
                Console.WriteLine("Have a nice day");
            }
            
            
        }
    }
}
