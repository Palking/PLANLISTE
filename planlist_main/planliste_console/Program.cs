using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using planliste_main;

namespace planliste_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Planliste newList = new Planliste();
            newList.Save();
        }
    }
}
