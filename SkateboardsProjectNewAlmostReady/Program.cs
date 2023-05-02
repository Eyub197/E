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
                Console.WriteLine("Error :(");
            }
            finally
            {
                Console.WriteLine("Have a nice day");
            }
            //control + . reabane
            //To do 
            //Fix the list methods so its Displays it like a table
            //Make a better update method
            //comments and hml
            //Add to the methods like in the update after the update "The table name has been updateted"
            //like that for delete, add, and whater else
        }
    }
}
