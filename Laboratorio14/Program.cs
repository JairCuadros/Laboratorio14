using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Screens.menu();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:opcion = Screens.Survey();break;
                    case 2:opcion = Screens.ShowDates();break;
                    case 3:opcion = Screens.ShowAnswers();break;
                    case 4:opcion = Screens.lookForAges();break;
                }
            } while (opcion != 5);
        }
    }
}
